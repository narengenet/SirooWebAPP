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
        public bool IsValidToChallenge = false;
        public long RemainingMoneyToAttendChallenge = -1;

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


                // check validity to attend in new challenge
                long _neededMoneyToAttentdInChallenge = Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge").ConstantValue);
                if (Convert.ToInt64(Amount) >= _neededMoneyToAttentdInChallenge)
                {
                    Graphs graphUser = _usersServices.GetAllGraphs().Where(g => g.User == creatorID).FirstOrDefault();
                    if (graphUser == null)
                    {
                        IsValidToChallenge = true;
                    }
                }

                Amount = string.Format("{0:C}", theUser.Money).Replace("$", "").Replace(".00", "");

                if (Request.Query["reason"]== "buypackage")
                {
                    RemainingMoneyToAttendChallenge = _neededMoneyToAttentdInChallenge - theUser.Money;
                }
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



