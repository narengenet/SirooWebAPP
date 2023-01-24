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
        public AddChallenge? AddChallenge { get; set; }

        public AddChallenge preDefinedChallenge;



        public string ResultMessage = "";
        public string ResultMessageSuccess = "danger";


        public void OnGet()
        {

            InitiateValidations();

        }


        void InitiateValidations()
        {

            preDefinedChallenge = new AddChallenge();
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

                        preDefinedChallenge.TheName = theUser.Name;
                        preDefinedChallenge.TheFamily = theUser.Family;
                        preDefinedChallenge.TheMobileNumber = theUser.Cellphone;
                    }
                }

            }
        }




        public IActionResult OnPostTakeMoney(AddChallenge addChallenge)
        {
            InitiateValidations();

            if (ModelState.IsValid)
            {



                // get current user
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Users theUser = _usersServices.GetUser(creatorID);
                Graphs theParentGraph = null;

                if (theUser != null && theUser.Money >= NeededMoneyToAttendInChallenge)
                {

                    Users theParentUser = _usersServices.GetAllUsers().Where(u => u.Username == addChallenge.Parent).FirstOrDefault();
                    Guid? theGrandParentUser = null;
                    bool isFirstChildOfParent = true;
                    int addedDaysToExpireGraph = Convert.ToInt32(_usersServices.GetConstantDictionary("expire_dates_for_challenge").ConstantValue);


                    if (theParentUser != null)
                    {
                        theParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theParentUser.Id && g.ExpireDate > DateTime.Today.AddDays(-1 * addedDaysToExpireGraph)).FirstOrDefault();
                        if (theParentGraph == null)
                        {
                            ResultMessage = "نام کاربری معرف اشتباه است.";
                            return Page();
                        }

                        theGrandParentUser = theParentGraph.GrandParent;
                        if (_usersServices.GetAllGraphs().Where(g => g.Parent == theParentUser.Id).FirstOrDefault() != null)
                        {
                            isFirstChildOfParent = false;
                        }

                    }



                    Graphs newGraph = new Graphs
                    {
                        User = creatorID,
                        DirectChildCount = 0,
                        Parent = (theParentUser == null) ? null : theParentUser.Id,
                        ExpireDate = DateTime.Today.AddDays(addedDaysToExpireGraph),
                        GrandParent = theGrandParentUser,
                        IsFirstChildOfParent = isFirstChildOfParent,
                        Created = DateTime.Now,
                        IsExpired = false,
                        ReceivedShared = 0

                    };

                    _usersServices.AddGraph(newGraph);

                    if (theParentUser!=null && isFirstChildOfParent==false)
                    {
                        theParentGraph.ReceivedShared += 1;
                        _usersServices.UpdateGraph(theParentGraph);
                    }

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
            }

            return Page();
        }
    }
}
