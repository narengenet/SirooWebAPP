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
        public string Amount = "1000000";

        [BindProperty]
        public AddMoney? AddMoney { get; set; }
        [BindProperty]
        public ReceiveMoney? ReceiveMoney { get; set; }

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

            // get current user
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);

            if (theUser != null && addMoney.NewAmount >= 500000)
            {
                Guid transacId = _usersServices.AddTransaction(new Transactions
                {
                    Created = DateTime.Now,
                    Amount = addMoney.NewAmount,
                    User = theUser.Id,
                    Status = "آغازپرداخت"

                });
                return Redirect("/Payment?theAmount=" + addMoney.NewAmount + "&theDescription=" + transacId.ToString());
                //return RedirectToPage("/Payment", new { theAmount = addMoney.NewAmount, theDescription = transacId.ToString() });
                //return RedirectToAction("../../Payment", new { theAmount = addMoney.NewAmount, theDescription = transacId.ToString() });


            }


            return Page();
        }

        public IActionResult OnPostGetMoney(ReceiveMoney receiveMoney)
        {


            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);
            if (receiveMoney.GetAmount <= theUser.Money && receiveMoney.CardNumber.Length > 15)
            {

                _usersServices.AddTransaction(new Transactions { Amount = -1 * (receiveMoney.GetAmount), Created = DateTime.Now, IsSuccessfull = false, User = theUser.Id, Status = "تقاضای برداشت" });
                theUser.Money -= receiveMoney.GetAmount;
                theUser.CardNumber = receiveMoney.CardNumber;
                _usersServices.UpdateUser(theUser);
                ResultMessageSuccess = "success";
                ResultMessage = "تقاضای دریافت وجه ارسال شد.";
                Amount = theUser.Money.ToString();
            }
            else
            {
                ResultMessage = "وجه درخواستی بیشتر از موجودی کیف پول شماست.";
            }

            return Page();
        }
    }
}



