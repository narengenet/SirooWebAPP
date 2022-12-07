using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class ChipUsagesModel : PageModel
    {

        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public ChipUsagesModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        [BindProperty(Name = "pagee", SupportsGet = true)]
        public int? pagee { get; set; }

        [BindProperty(Name = "serialorpin", SupportsGet = true)]
        public string? serialorpin { get; set; }



        public void OnGetSearch()
        {
            allUsedChipsCount = 0;


            allUsedChipsCount = _usersServices.GetAllChips().Where(t => t.IsUsed == true).ToList<Chips>().Count;
            List<Chips> usedChips = _usersServices.GetAllChips().Where(t => t.SerialNumber == Convert.ToInt64(serialorpin.Trim()) || t.PIN==serialorpin).OrderByDescending(t => t.Created).ToList<Chips>();
            if (usedChips.Count > 0)
            {
                transacs = new List<RequestMoneyUser>();
                foreach (Chips item in usedChips)
                {
                    if (item.IsUsed)
                    {
                        Users theUser = _usersServices.GetUser(item.UsedBy);
                        if (theUser != null)
                        {
                            transacs.Add(new RequestMoneyUser
                            {
                                UserName = theUser.Username,
                                PhoneNumber = theUser.Cellphone,
                                RequestMoney = item.Points,
                                Data1 = item.SerialNumber.ToString(),
                                Data2 = item.PIN,
                                RequestID = item.Id,
                                RequestedDate = (DateTime)item.Created
                            });
                        }
                    }
                    else
                    {
                        transacs.Add(new RequestMoneyUser
                        {
                            PhoneNumber = "استفاده نشده",
                            UserName = "",
                            RequestMoney = item.Points,
                            Data1 = item.SerialNumber.ToString(),
                            Data2 = item.PIN,
                            RequestID = item.Id,
                            RequestedDate = (DateTime)item.Created
                        });
                    }

                   
                }

                hasValue = true;
                
            }

            isSearch = true;


        }


        public void OnGetDisplay()
        {
            isSearch = false;
            allUsedChipsCount = 0;
            int thePage = 0;
            if (pagee != null)
            {
                thePage = Convert.ToInt32(pagee);
                if (thePage == -1)
                {
                    thePage = 0;
                }
            }

            allUsedChipsCount = _usersServices.GetAllChips().Where(t => t.IsUsed == true).ToList<Chips>().Count;
            List<Chips> usedChips = _usersServices.GetAllChips().Where(t => t.IsUsed == true).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<Chips>();
            if (usedChips.Count > 0)
            {
                transacs = new List<RequestMoneyUser>();
                foreach (Chips item in usedChips)
                {
                    Users theUser = _usersServices.GetUser(item.UsedBy);
                    if (theUser != null)
                    {
                        transacs.Add(new RequestMoneyUser
                        {
                            UserName = theUser.Username,
                            PhoneNumber = theUser.Cellphone,
                            RequestMoney = item.Points,
                            Data1 = item.SerialNumber.ToString(),
                            Data2 = item.PIN,
                            RequestID = item.Id,
                            RequestedDate = (DateTime)item.LastModified
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
        public int allUsedChipsCount { get; set; }

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
