using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class LastTransactionsModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public LastTransactionsModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        [BindProperty(Name = "pagee", SupportsGet = true)]
        public int? pagee { get; set; }


        public void OnGetDisplay()
        {
            allTransactionCount = 0;
            int thePage = 0;
            if (pagee != null)
            {
                thePage = Convert.ToInt32(pagee);
                if (thePage==-1)
                {
                    thePage = 0;
                }
            }

            allTransactionCount = _usersServices.GetAllTransactions().Where(t => t.IsSuccessfull == true && t.Status == "موفقیت آمیز").ToList<Transactions>().Count;
            List<Transactions> trans = _usersServices.GetAllTransactions().Where(t => t.IsSuccessfull == true && t.Status == "موفقیت آمیز").OrderByDescending(t => t.Created).Skip(thePage*10).Take(10).ToList<Transactions>();
            if (trans.Count > 0)
            {
                transacs = new List<RequestMoneyUser>();
                foreach (Transactions item in trans)
                {
                    Users theUser = _usersServices.GetUser(item.User);
                    if (theUser != null)
                    {
                        transacs.Add(new RequestMoneyUser
                        {
                            UserName = theUser.Username,
                            PhoneNumber = theUser.Cellphone,
                            RequestMoney = item.Amount,
                            RequestID = item.Id,
                            RequestedDate= (DateTime)item.Created
                        });
                    }
                }
                
                hasValue = true;
                haveNext = thePage;
            }
            else
            {
                haveNext=thePage;
                hasValue = false;
            }

        }

        [BindProperty]
        public List<RequestMoneyUser> transacs { get; set; }
        
        
        [BindProperty]
        public int allTransactionCount{ get; set; }
        
        [BindProperty]
        public int haveNext{ get; set; }

        [BindProperty]
        public bool hasValue{ get; set; }


        public void OnGet()
        {
            var sina = "1";

        }
    }
}
