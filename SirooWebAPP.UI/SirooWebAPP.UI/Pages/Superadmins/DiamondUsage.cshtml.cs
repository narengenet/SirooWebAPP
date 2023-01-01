using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;


namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class DiamondUsageModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public DiamondUsageModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        [BindProperty(Name = "pagee", SupportsGet = true)]
        public int? pagee { get; set; }

        [BindProperty(Name = "diamondorusername", SupportsGet = true)]
        public string? diamondorusername { get; set; }



        public void OnGetSearch()
        {
            allDiamondUsageCount = 0;

            int thePage = 0;
            if (pagee != null)
            {
                thePage = Convert.ToInt32(pagee);
                if (thePage == -1)
                {
                    thePage = 0;
                }
            }


            var isNumeric = int.TryParse(diamondorusername, out int searchedDiamondWon);
            if (diamondorusername.StartsWith("0") && diamondorusername.Length > 1)
            {
                isNumeric = false;
            }
            Guid theUserID = Guid.Empty;
            if (!isNumeric)
            {
                Users _usr = _usersServices.GetAllUsers().Where(u => u.Username == diamondorusername || u.Cellphone == diamondorusername).FirstOrDefault();
                if (_usr != null)
                {
                    theUserID = _usr.Id;
                }
            }


            allDiamondUsageCount = _usersServices.GetAllDiamondUsages().Where(t => t.IsDeleted == false).ToList<DiamondUsages>().Count;
            List<DiamondUsages> diamondUsed = new List<DiamondUsages>();
            if (isNumeric)
            {
                diamondUsed = _usersServices.GetAllDiamondUsages().Where(t => t.DiamondsWon == Convert.ToInt32(diamondorusername.Trim())).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<DiamondUsages>();
            }
            else
            {
                diamondUsed = _usersServices.GetAllDiamondUsages().Where(t => t.User == theUserID).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<DiamondUsages>();
            }


            if (diamondUsed.Count > 0)
            {
                transacs = new List<RequestMoneyUser>();
                foreach (DiamondUsages item in diamondUsed)
                {
                    Users theUser = _usersServices.GetUser(item.User);
                    if (theUser != null)
                    {
                        transacs.Add(new RequestMoneyUser
                        {
                            UserName = theUser.Username,
                            PhoneNumber = theUser.Cellphone,
                            RequestMoney = item.DiamondsWon,
                            RequestID = item.Id,
                            Data1 = (item.LastModifiedBy == null) ? "-1" : _usersServices.GetUser(Guid.Parse(item.LastModifiedBy)).Username,
                            Data2 = (item.PointCharged != null) ? item.PointCharged.ToString() : "---",
                            RequestedDate = (DateTime)item.Created
                        });
                    }
                }


                hasValue = true;
                haveNext = thePage;
            }
            else
            {
                haveNext = thePage;
                hasValue = false;
            }
            isSearch = true;


        }


        public void OnGetDisplay()
        {
            isSearch = false;
            allDiamondUsageCount = 0;
            int thePage = 0;
            if (pagee != null)
            {
                thePage = Convert.ToInt32(pagee);
                if (thePage == -1)
                {
                    thePage = 0;
                }
            }

            allDiamondUsageCount = _usersServices.GetAllDiamondUsages().Count;
            List<DiamondUsages> diamondUsed = _usersServices.GetAllDiamondUsages().Where(t => t.IsDeleted == false).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<DiamondUsages>();
            if (diamondUsed.Count > 0)
            {
                transacs = new List<RequestMoneyUser>();
                foreach (DiamondUsages item in diamondUsed)
                {
                    Users theUser = _usersServices.GetUser(item.User);
                    if (theUser != null)
                    {
                        transacs.Add(new RequestMoneyUser
                        {
                            UserName = theUser.Username,
                            PhoneNumber = theUser.Cellphone,
                            RequestMoney = item.DiamondsWon,
                            RequestID = item.Id,
                            Data1 = (item.LastModifiedBy == null) ? "-1" : _usersServices.GetUser(Guid.Parse(item.LastModifiedBy)).Username,
                            Data2 = (item.PointCharged != null) ? item.PointCharged.ToString() : "---",
                            RequestedDate = (DateTime)item.Created
                        });
                    }
                }

                hasValue = true;
                haveNext = thePage;
            }
            else
            {
                haveNext = thePage;
                hasValue = false;
            }

        }

        [BindProperty]
        public List<RequestMoneyUser> transacs { get; set; }


        [BindProperty]
        public int allDiamondUsageCount { get; set; }

        [BindProperty]
        public int haveNext { get; set; }

        [BindProperty]
        public bool hasValue { get; set; }

        [BindProperty]
        public bool isSearch { get; set; }


        public void OnGet()
        {
            var sina = "1";

        }
    }
}
