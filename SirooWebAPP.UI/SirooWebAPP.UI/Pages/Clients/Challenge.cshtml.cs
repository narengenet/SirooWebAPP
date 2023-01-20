using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class ChallengeModel : PageModel
    {

        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public ChallengeModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }


        public bool IsValidToChallenge = false;
        public long NeededMoneyToAttendInChallenge = 0;

        [BindProperty]
        public AddMoney? AddMoney { get; set; }
        
        [BindProperty]
        public AddChallenge? AddChallenge{ get; set; }


        public void OnGet()
        {

            InitiateValidations();

        }


        void InitiateValidations()
        {
            // get current user
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);
            string Amount = "";



            if (theUser != null)
            {
                Amount = theUser.Money.ToString();


                // check validity to attend in new challenge
                NeededMoneyToAttendInChallenge = Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge").ConstantValue);
                if (Convert.ToInt64(Amount) >= NeededMoneyToAttendInChallenge)
                {
                    Graphs graphUser = _usersServices.GetAllGraphs().Where(g => g.User == creatorID).FirstOrDefault();
                    if (graphUser == null)
                    {
                        IsValidToChallenge = true;
                    }
                }

            }
        }




        public IActionResult OnPostTakeMoney(AddChallenge addChallenge)
        {
            

            InitiateValidations();

            // get current user
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);

            if (theUser != null && theUser.Money >= NeededMoneyToAttendInChallenge)
            {

                int addedDaysToExpireGraph = Convert.ToInt32(_usersServices.GetConstantDictionary("expire_dates_for_challenge").ConstantValue);

                //_usersServices.AddGraph(new Graphs
                //{
                //     User=creatorID,
                //      Created=DateTime.Today,
                //       ExpireDate=DateTime.Today.AddDays(addedDaysToExpireGraph),
                //        Parent=
                //})


                //Guid transacId = _usersServices.AddTransaction(new Transactions
                //{
                //    Created = DateTime.Now,
                //    Amount = NeededMoneyToAttendInChallenge,
                //    User = theUser.Id,
                //    Status = "شرکت در چالش",
                //    IsSuccessfull=true,
                //    ReferenceID=

                //});
                //return Redirect("/Payment?theAmount=" + addMoney.NewAmount + "&theDescription=" + transacId.ToString());

            }


            return Page();
        }
    }
}
