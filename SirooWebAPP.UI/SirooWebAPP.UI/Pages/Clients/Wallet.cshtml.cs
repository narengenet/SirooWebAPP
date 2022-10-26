using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class WalletModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public WalletModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;

        }

        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";
        public string Amount = "500000";

        [BindProperty]
        public AddMoney? AddMoney { get; set; }

        public void OnGet()
        {
            // get current user
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);

            if (theUser != null)
            {
                Amount = theUser.Money.ToString();
            }
        }
        public IActionResult OnPostAddMoney(AddMoney addMoney)
        {
            if (ModelState.IsValid)
            {
                // get current user
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Users theUser = _usersServices.GetUser(creatorID);

                if (theUser != null)
                {
                    Guid transacId= _usersServices.AddTransaction(new Transactions
                    {
                        Created = DateTime.Now,
                        Amount = addMoney.NewAmount,
                        User = theUser.Id,
                        Status="آغازپرداخت"
                         
                    });
                    return Redirect("/Payment?theAmount=" + addMoney.NewAmount + "&theDescription=" + transacId.ToString());
                    //return RedirectToPage("/Payment", new { theAmount = addMoney.NewAmount, theDescription = transacId.ToString() });
                    //return RedirectToAction("../../Payment", new { theAmount = addMoney.NewAmount, theDescription = transacId.ToString() });


                }
            }

            return Page();
        }
    }
}



