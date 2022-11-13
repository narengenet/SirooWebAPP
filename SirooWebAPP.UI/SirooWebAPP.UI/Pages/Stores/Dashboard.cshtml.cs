using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.QrCode;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Stores
{
    public class DashboardModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public DashboardModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;
            _httpContextAccessor = httpContextAccessor;


        }

        [BindProperty]
        public AddQRModel? AddQRModel { get; set; }

        public List<TicketsModel> QrCodes = new List<TicketsModel>();
        public void OnGet()
        {
            PrepareQRs();


        }

        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";
        public long Credit = 0;
        public long Money = 0;
        public int theRatio = 0;



        public IActionResult OnPostChangeMoneyToCredit()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users usr = _usersServices.GetUser(creatorID);

            if (usr.Money > 0)
            {
                int ratio = Convert.ToInt32(_usersServices.GetConstantDictionary("money_to_credit_ratio").ConstantValue);
                int addedCredit = Convert.ToInt32(usr.Money / ratio);
                long paidMoney = usr.Money;
                usr.Money = 0;
                usr.Credits += addedCredit;
                _usersServices.UpdateUser(usr);
                Money = 0;
                Credit = usr.Credits;
                ResultMessageSuccess = "success";
                ResultMessage = "موجودی ریالی شما تبدیل به اعتبار شد.";
                Guid _purchasedId = _usersServices.AddPurchaseCredit(new Purchases { Created = DateTime.Now, User = creatorID, MoneyPaied = paidMoney, PurchasedCredit = addedCredit });
                CalculatePercents(_purchasedId, creatorID, paidMoney, addedCredit);
            }
            else
            {
                ResultMessage = "شما موجودی ریالی کافی برای تبدیل به اعتبار ندارید.";
            }
            PrepareQRs();
            return Page();
        }


        private void CalculatePercents(Guid purchaseId, Guid userId, long PurchasedMoney, int PurchasedCredit)
        {
            //Transactions transac = _usersServices.GetAllTransactions().Where(t => t.Id == TransactionId).FirstOrDefault();
            int marketerPercent = Convert.ToInt32(_usersServices.GetConstantDictionary("def_percent_for_marketer").ConstantValue);
            int zoneadminPercent = Convert.ToInt32(_usersServices.GetConstantDictionary("def_percent_for_zoneadmin").ConstantValue);
            int countryadminPercent = Convert.ToInt32(_usersServices.GetConstantDictionary("def_percent_for_countryadmin").ConstantValue);

            //if (transac != null && transac.IsSuccessfull)
            //{
            Users store = _usersServices.GetUser(userId);

            UsersRoles _ur = _usersServices.GetAllUsersRoles().Where(ur => ur.User == userId && ur.IsDeleted == false).FirstOrDefault();
            Users marketer = _usersServices.GetUser(_ur.CreatedBy);

            _ur = _usersServices.GetAllUsersRoles().Where(ur => ur.User == marketer.Id && ur.IsDeleted == false).FirstOrDefault();

            // check if zoner is exist by his/her role or not
            string marketerRoleName = _usersServices.GetUserRoles(marketer.Id).FirstOrDefault().RoleName;

            Users zoner = null;
            Users country = null;
            if (marketerRoleName == "super" || marketerRoleName == "admin" || marketerRoleName == "countryadmin")
            {
                zoner = marketer;
                country = marketer;
            }
            if (marketerRoleName == "zoneadmin")
            {
                zoner = marketer;
                _ur = _usersServices.GetAllUsersRoles().Where(ur => ur.User == zoner.Id && ur.IsDeleted == false).FirstOrDefault();
                country = _usersServices.GetUser(_ur.CreatedBy);
            }
            if (marketerRoleName == "marketer")
            {
                _ur = _usersServices.GetAllUsersRoles().Where(ur => ur.User == marketer.Id && ur.IsDeleted == false).FirstOrDefault();
                string zoneAdminRoleName = _usersServices.GetUserRoles(_ur.CreatedBy).FirstOrDefault().RoleName;
                if (zoneAdminRoleName == "zoneadmin")
                {
                    zoner = _usersServices.GetUser(_ur.CreatedBy);
                    _ur = _usersServices.GetAllUsersRoles().Where(ur => ur.User == zoner.Id && ur.IsDeleted == false).FirstOrDefault();
                    country = _usersServices.GetUser(_ur.CreatedBy);
                }

                if (zoneAdminRoleName == "countryadmin" || zoneAdminRoleName == "admin" || zoneAdminRoleName == "super")
                {
                    zoner = _usersServices.GetUser(_ur.CreatedBy);
                    country = zoner;
                }

            }




            long _addedMoneies = (marketerPercent * PurchasedMoney) / 100;
            marketer.Money += _addedMoneies;
            _usersServices.UpdateUser(marketer);
            _usersServices.AddTransactionPercent(new TransactionPercents { FromUser = userId, ToUser = marketer.Id, Transaction = purchaseId, FromAmount = PurchasedMoney, ToAmount = _addedMoneies, Created = DateTime.Now, Percentage = marketerPercent, Description = "سود بازاریای فروشگاه " + store.Username, ReferenceID = "خرید " + PurchasedCredit.ToString() + " اعتبار" });

            _addedMoneies = (zoneadminPercent * PurchasedMoney) / 100;
            zoner.Money += _addedMoneies;
            _usersServices.UpdateUser(zoner);
            _usersServices.AddTransactionPercent(new TransactionPercents { FromUser = marketer.Id, ToUser = zoner.Id, Transaction = purchaseId, FromAmount = PurchasedMoney, ToAmount = _addedMoneies, Created = DateTime.Now, Percentage = zoneadminPercent, Description = "سود از بازاریاب " + marketer.Username, ReferenceID = "خرید " + PurchasedCredit.ToString() + " اعتبار" });

            _addedMoneies = (countryadminPercent * PurchasedMoney) / 100;
            country.Money += _addedMoneies;
            _usersServices.UpdateUser(country);
            _usersServices.AddTransactionPercent(new TransactionPercents { FromUser = zoner.Id, ToUser = country.Id, Transaction = purchaseId, FromAmount = PurchasedMoney, ToAmount = _addedMoneies, Created = DateTime.Now, Percentage = countryadminPercent, Description = "سود از منطقه " + zoner.Username, ReferenceID = "خرید " + PurchasedCredit.ToString() + " اعتبار" });


            //}
        }

        public IActionResult OnPostAddQR(AddQRModel addQRModel)
        {



            if (ModelState.IsValid)
            {
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Roles role = _usersServices.GetUserRoles(creatorID).OrderBy(u => u.Priority).FirstOrDefault();
                if (role != null)
                {
                    if (role.RoleName == "store")
                    {
                        DonnationTickets _ticket = new DonnationTickets
                        {
                            IsCredit = false,
                            Donner = creatorID,
                            Value = addQRModel.Points,
                            Created = DateTime.Now,
                            RemainedCapacity = addQRModel.Capacity
                        };
                        _usersServices.AddDonnationTicket(_ticket);
                        ResultMessage = "QR شما با موفقیت ایجاد شد.";
                        ResultMessageSuccess = "success";
                    }
                    else
                    {
                        ResultMessage = "فقط کاربر با نقش فروشگاه میتواند QR تولید کند.";
                    }
                }
                else
                {
                    ResultMessage = "شما هیچ نقش تعیین شده ای ندارید.";
                }

            }

            PrepareQRs();
            return Page();
        }

        private void PrepareQRs()
        {
            theRatio = Convert.ToInt32(_usersServices.GetConstantDictionary("money_to_credit_ratio").ConstantValue);

            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            List<DonnationTickets> tickets = _usersServices.GetAllDonnationTickets().Where(t => t.Donner == creatorID && t.RemainedCapacity > 0).ToList<DonnationTickets>();
            foreach (DonnationTickets item in tickets)
            {
                //string qrText = HelperFunctions.CreateQR("https://localhost:7051/Public/AddPoints?ticket=" + item.Id.ToString());
                string qrText = HelperFunctions.CreateQR(_httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value + "/Public/AddPoints?ticket=" + item.Id.ToString());
                //TicketsModel _t = new TicketsModel { QRsrc = qrText, Capacity = item.RemainedCapacity, Val = item.Value, TicketURL = "https://localhost:7051/Public/AddPoints?ticket=" + item.Id.ToString() };
                TicketsModel _t = new TicketsModel
                {
                    QRsrc = qrText,
                    Capacity = item.RemainedCapacity,
                    Val = item.Value,
                    QRID = item.Id,
                    TicketURL = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value + "/Public/AddPoints?ticket=" + item.Id.ToString()
                };
                QrCodes.Add(_t);
            }



            Users usr = _usersServices.GetUser(creatorID);
            Money = usr.Money;
            Credit = usr.Credits;
        }
    }
}
