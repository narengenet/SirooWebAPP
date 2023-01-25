using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Superadmins
{



    public class ChallengeUsageModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public ChallengeUsageModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
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



            Guid theUserID = Guid.Empty;

            Users _usr = _usersServices.GetAllUsers().Where(u => u.Username == diamondorusername || u.Cellphone == diamondorusername).FirstOrDefault();
            if (_usr != null)
            {
                theUserID = _usr.Id;
            }



            allDiamondUsageCount = _usersServices.GetAllGraphHistoryData().Where(t => t.IsDeleted == false).ToList<GraphHistory>().Count;
            List<GraphHistory> diamondUsed = new List<GraphHistory>();
            if (theUserID != Guid.Empty)
            {
                diamondUsed = _usersServices.GetAllGraphHistoryData().Where(t => t.User == theUserID || t.ToUser == theUserID).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<GraphHistory>();
            }



            if (diamondUsed.Count > 0)
            {
                transacs = new List<RequestMoneyUser>();
                foreach (GraphHistory item in diamondUsed)
                {
                    Users theUser = _usersServices.GetUser(item.User);
                    Users toUser = _usersServices.GetUser(item.ToUser);
                    if (theUser != null)
                    {
                        transacs.Add(new RequestMoneyUser
                        {
                            UserName = theUser.Username,
                            RequestID = item.Id,
                            Data1 = toUser.Username,
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

            allDiamondUsageCount = _usersServices.GetAllGraphHistoryData().Count;
            List<GraphHistory> diamondUsed = _usersServices.GetAllGraphHistoryData().Where(t => t.IsDeleted == false).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<GraphHistory>();
            if (diamondUsed.Count > 0)
            {
                transacs = new List<RequestMoneyUser>();
                foreach (GraphHistory item in diamondUsed)
                {
                    Users theUser = _usersServices.GetUser(item.User);
                    Users toUser = _usersServices.GetUser(item.ToUser);
                    if (theUser != null)
                    {
                        transacs.Add(new RequestMoneyUser
                        {
                            UserName = theUser.Username,
                            RequestID = item.Id,
                            Data1 = toUser.Username,
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
