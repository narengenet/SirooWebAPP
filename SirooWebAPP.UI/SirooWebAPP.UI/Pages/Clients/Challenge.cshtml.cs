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
        public bool HasChallenge = false;
        public long NeededMoneyToAttendInChallenge = 0;
        public int ShareReceivedUntilNow = 0;
        public int DirectInviteds = 0;
        public int DeadlineDays = 0;
        public int RemainingDays = 0;


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
                DeadlineDays = Convert.ToInt32(_usersServices.GetConstantDictionary("expire_dates_for_challenge").ConstantValue);

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
                    else
                    {
                        HasChallenge = true;
                        ShareReceivedUntilNow = _usersServices.GetAllGraphHistoryData().Where(g => g.ToUser == creatorID).ToList().Count;
                        DirectInviteds = _usersServices.GetAllGraphs().Where(g => g.Parent == creatorID).ToList().Count;
                        RemainingDays = Convert.ToInt32((graphUser.ExpireDate - Convert.ToDateTime(graphUser.Created)).TotalDays);
                    }
                }
                else
                {
                    Graphs graphUser = _usersServices.GetAllGraphs().Where(g => g.User == creatorID).FirstOrDefault();
                    if (graphUser != null)
                    {
                        HasChallenge = true;
                        ShareReceivedUntilNow = _usersServices.GetAllGraphHistoryData().Where(g => g.ToUser == creatorID).ToList().Count;
                        DirectInviteds = _usersServices.GetAllGraphs().Where(g => g.Parent == creatorID).ToList().Count;
                        RemainingDays = Convert.ToInt32((graphUser.ExpireDate - Convert.ToDateTime(graphUser.Created)).TotalDays);
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

                // check validity to challenge
                if (theUser != null && theUser.Money >= NeededMoneyToAttendInChallenge)
                {
                    // initiate required data
                    Users theParentUser = _usersServices.GetAllUsers().Where(u => u.Username == addChallenge.Parent).FirstOrDefault();
                    Guid? theGrandParentUser = null;
                    bool isFirstChildOfParent = true;
                    int addedDaysToExpireGraph = Convert.ToInt32(_usersServices.GetConstantDictionary("expire_dates_for_challenge").ConstantValue);


                    // if parent user is not null
                    if (theParentUser != null)
                    {
                        //theParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theParentUser.Id && g.ExpireDate > DateTime.Today.AddDays(-1 * addedDaysToExpireGraph)).FirstOrDefault();
                        theParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theParentUser.Id).FirstOrDefault();
                        if (theParentGraph == null)
                        {
                            ResultMessage = "نام کاربری معرف اشتباه است.";
                            return Page();
                        }

                        // check if parent has another child 
                        if (_usersServices.GetAllGraphs().Where(g => g.Parent == theParentUser.Id).FirstOrDefault() != null)
                        {
                            //parent has not any child
                            isFirstChildOfParent = false;
                            theGrandParentUser = theParentGraph.GrandParent;
                        }
                        else
                        {
                            if (theParentGraph.GrandParent!=theParentGraph.User)
                            {
                                theGrandParentUser = theParentGraph.GrandParent;
                            }
                            
                        }

                    }
                    else
                    {

                        if (addChallenge.Parent != null)
                        {
                            ResultMessage = "نام کاربری معرف اشتباه است.";
                            return Page();

                        }
                        //// check if user has another child, then current child grand parent 
                        //if(_usersServices.GetAllGraphs().Where(g => g.Parent == creatorID).FirstOrDefault() == null)
                        //{
                        //    // if there is no parent, grandparent of current user is himself/herself
                        theGrandParentUser = creatorID;
                        //}

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

                    // add prize to parent if this is not first child
                    if (theParentUser != null && isFirstChildOfParent == false)
                    {
                        theParentGraph.ReceivedShared += 1;
                        _usersServices.UpdateGraph(theParentGraph);

                        _usersServices.AddGraphHistory(new GraphHistory
                        {
                            Created = DateTime.Now,
                            User = creatorID,
                            ToUser = theParentUser.Id,
                            Graph = newGraph.Id,
                        });


                    }


                    // add prize to grand father if exist
                    if (theGrandParentUser != null && isFirstChildOfParent && theGrandParentUser != creatorID)
                    {
                        Graphs theGrandParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theGrandParentUser && g.ExpireDate > DateTime.Today.AddDays(-1 * addedDaysToExpireGraph)).FirstOrDefault();
                        theGrandParentGraph.ReceivedShared += 1;
                        _usersServices.UpdateGraph(theGrandParentGraph);

                        _usersServices.AddGraphHistory(new GraphHistory
                        {
                            Created = DateTime.Now,
                            Graph = newGraph.Id,
                            User = creatorID,
                            ToUser = Guid.Parse(theGrandParentUser.ToString())
                        });
                    }



                    _usersServices.AddChallengeUserData(new ChallengeUserData
                    {
                        Cellphone = addChallenge.TheMobileNumber,
                        BirthDate = addChallenge.TheBirthDate,
                        Name = addChallenge.TheName,
                        Family = addChallenge.TheFamily,
                        FatherName = addChallenge.TheFatherName,
                        IdentityID = addChallenge.TheIDNumber,
                        NationalID = addChallenge.TheNationalID,
                        IsMarried = addChallenge.IsMarried,
                        User = creatorID,
                        Graph = newGraph.Id,
                        Created = DateTime.Now

                    });


                    _usersServices.AddTransaction(new Transactions
                    {
                        Amount = -1*NeededMoneyToAttendInChallenge,
                        Created = DateTime.Now,
                        ReferenceID = newGraph.Id.ToString(),
                        Status = "شرکت در چالش",
                        User = creatorID
                    });

                    theUser.Money -= NeededMoneyToAttendInChallenge;
                    _usersServices.UpdateUser(theUser);

                    ResultMessage = "ثبت شد.";
                    ResultMessageSuccess = "success";

                    IsValidToChallenge = false;
                    HasChallenge = true;

                    return Page();
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
