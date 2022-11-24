using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class RequestMoneyModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;

        [BindProperty]
        public List<RequestMoneyUser> RequestMoneyUser { get; set; }

        public RequestMoneyModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }
        public void OnGet()
        {
            RequestMoneyUser = new List<RequestMoneyUser>();
            List<Transactions> transacs = _usersServices.GetAllTransactions().Where(t => t.Status == "تقاضای برداشت" && t.IsSuccessfull == false).ToList<Transactions>();
            for (int i = 0; i < transacs.Count; i++)
            {
                Users theuser = _usersServices.GetUser(transacs[i].User);
                if (theuser != null)
                {
                    RequestMoneyUser.Add(new ViewModels.RequestMoneyUser
                    {
                        PhoneNumber = theuser.Cellphone,
                        RequestID = transacs[i].Id,
                        RequestMoney = transacs[i].Amount,
                        UserName = theuser.Username,
                        CardNumber=theuser.CardNumber

                    });
                }
            }


        }
    }
}
