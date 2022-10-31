using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class PaymentResultModel : PageModel
    {

        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public PaymentResultModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }



        [BindProperty(Name = "RefId", SupportsGet = true)]
        public string? RefId { get; set; }
        [BindProperty(Name = "TransactionId", SupportsGet = true)]
        public Guid? TransactionId { get; set; }

        [BindProperty(Name = "Code", SupportsGet = true)]
        public string? Code { get; set; }
        [BindProperty(Name = "Status", SupportsGet = true)]
        public bool? Status { get; set; }



        public string ResultMessage = "";
        public string ResultMessageSuccess = "danger";
        public void OnGet()
        {
        }
        public void OnGetDisplay()
        {


            RefId = RefId.Replace("A00000000000000000000000000", "");
            

            if (Status==true)
            {

                CalculatePercents();

                ResultMessageSuccess = "success";
                ResultMessage = "پرداخت موفقیت آمیز بود. کد پیگیری:" + RefId;
            }
            else
            {
                ResultMessage = "خطا در پرداخت. کد پیگیری: " + RefId;
            }

        }

        private void CalculatePercents()
        {
            Transactions transac = _usersServices.GetAllTransactions().Where(t => t.Id == TransactionId).First();
            int marketerPercent = Convert.ToInt32(_usersServices.GetConstantDictionary("def_percent_for_marketer").ConstantValue);
            int zoneadminPercent = Convert.ToInt32(_usersServices.GetConstantDictionary("def_percent_for_zoneadmin").ConstantValue);
            int countryadminPercent = Convert.ToInt32(_usersServices.GetConstantDictionary("def_percent_for_countryadmin").ConstantValue);

            if (transac!=null && transac.IsSuccessfull)
            {
                Users store = _usersServices.GetUser(transac.User);

                UsersRoles _ur = _usersServices.GetAllUsersRoles().Where(ur => ur.User == transac.User && ur.IsDeleted==false).FirstOrDefault();
                Users marketer = _usersServices.GetUser(_ur.CreatedBy);
         
                _ur = _usersServices.GetAllUsersRoles().Where(ur => ur.User == marketer.Id && ur.IsDeleted == false).FirstOrDefault();
                Users zoner = _usersServices.GetUser(_ur.CreatedBy);
                
                _ur= _usersServices.GetAllUsersRoles().Where(ur => ur.User == zoner.Id && ur.IsDeleted == false).FirstOrDefault();
                Users country = _usersServices.GetUser(_ur.CreatedBy);

                long _addedMoneies = (marketerPercent * transac.Amount) / 100;
                marketer.Money += _addedMoneies;
                _usersServices.UpdateUser(marketer);
                _usersServices.AddTransactionPercent(new TransactionPercents { FromUser = transac.User, ToUser = marketer.Id, Transaction = transac.Id, FromAmount = transac.Amount, ToAmount = _addedMoneies, Created = DateTime.Now, Percentage = marketerPercent, Description = "سود بازاریای فروشگاه "+ store.Username, ReferenceID=transac.ReferenceID });

                _addedMoneies = (zoneadminPercent * transac.Amount) / 100;
                zoner.Money += _addedMoneies;
                _usersServices.UpdateUser(zoner);
                _usersServices.AddTransactionPercent(new TransactionPercents { FromUser = marketer.Id, ToUser = zoner.Id, Transaction = transac.Id, FromAmount = transac.Amount, ToAmount = _addedMoneies, Created = DateTime.Now, Percentage = zoneadminPercent, Description = "سود از بازاریاب "+marketer.Username, ReferenceID=transac.ReferenceID });

                _addedMoneies = (countryadminPercent * transac.Amount) / 100;
                country.Money += _addedMoneies;
                _usersServices.UpdateUser(country);
                _usersServices.AddTransactionPercent(new TransactionPercents { FromUser = zoner.Id, ToUser = zoner.Id, Transaction = transac.Id, FromAmount = transac.Amount, ToAmount = _addedMoneies, Created = DateTime.Now, Percentage = countryadminPercent, Description = "سود از منطقه "+zoner.Username, ReferenceID=transac.ReferenceID });


            }
        }
    }
}
