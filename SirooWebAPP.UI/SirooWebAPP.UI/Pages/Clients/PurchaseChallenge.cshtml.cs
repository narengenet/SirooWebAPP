using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class PurchaseChallengeModel : PageModel
    {

        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public PurchaseChallengeModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }


        public bool IsValidToChallenge = false;
        public bool HasChallenge = false;
        public long NeededMoneyToAttendInChallenge = 0;
        public int ShareReceivedUntilNow = 0;
        public string MaximumPrize = "";
        public int DirectInviteds = 0;
        public int DeadlineDays = 0;
        public int RemainingDays = 0;


        [BindProperty]
        public AddChallenge? AddChallenge { get; set; }

        public AddChallenge preDefinedChallenge;



        public string ResultMessage = "";
        public string ResultMessageSuccess = "danger";


        public int neededMoney1 = 0;
        public int neededMoney2 = 0;
        public int neededMoney3 = 0;

        public long currentMoney = 0;

        public List<SelectListItem> UserChallengesOptions { get; set; }

        [BindProperty]
        public int? ChallengeModeIndex { get; set; }


        public void OnGet()
        {

            InitiateValidations();

        }

        public bool HasHistory { get; set; }
        public List<int?> ValidGraphHistoryAttended { get; set; }

        void InitiateValidations()
        {

            UserChallengesOptions = new List<SelectListItem>();


            neededMoney1 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_1").ConstantValue);
            neededMoney2 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_2").ConstantValue);
            neededMoney3 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_3").ConstantValue);



            preDefinedChallenge = new AddChallenge();
            // get current user
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);
            string Amount = "";



            if (theUser != null)
            {
                Amount = theUser.Money.ToString();
                currentMoney = theUser.Money;


                List<Graphs> _graphs = _usersServices.GetAllGraphs().Where(g => g.User == theUser.Id && g.IsDeleted == false).ToList<Graphs>();
                if (_graphs.Count != 0)
                {
                    
                    List<Graphs> _validGraphs = _graphs.Where(g => g.ExpireDate > DateTime.Today).ToList<Graphs>();
                    ChallengeUserData challengeUserData = _usersServices.GetAllChallengeUserData().Where(cud => cud.User == theUser.Id).FirstOrDefault();

                    AddChallenge = new AddChallenge();
                    if (challengeUserData != null)
                    {
                        HasHistory = true;
                        AddChallenge.IsMarried = challengeUserData.IsMarried ? 1 : 2;
                        AddChallenge.TheFatherName = challengeUserData.FatherName;
                        AddChallenge.TheName = challengeUserData.Name;
                        AddChallenge.TheBirthDate = challengeUserData.BirthDate;
                        AddChallenge.TheFamily = challengeUserData.Family;
                        AddChallenge.TheNationalID = challengeUserData.NationalID;
                        AddChallenge.TheIDNumber = challengeUserData.IdentityID;
                        AddChallenge.TheMobileNumber = challengeUserData.Cellphone;
                    }
                    else
                    {
                        HasHistory = false;
                    }



                    if (_validGraphs != null)
                    {
                        ValidGraphHistoryAttended = _validGraphs.Select(g => g.GraphTypeIndex).ToList<int?>();

                        if (ValidGraphHistoryAttended.Count(g => g.Value == 1) == 0)
                        {
                            UserChallengesOptions.Add(new SelectListItem
                            {
                                Text = "پکیج " + neededMoney1 / 10 + " تومانی",
                                Value = "1"
                            });
                        }

                        if (ValidGraphHistoryAttended.Count(g => g.Value == 2) == 0)
                        {
                            UserChallengesOptions.Add(new SelectListItem
                            {
                                Text = "پکیج " + neededMoney2 / 10 + " تومانی",
                                Value = "2"
                            });
                        }


                        if (ValidGraphHistoryAttended.Count(g => g.Value == 3) == 0)
                        {
                            UserChallengesOptions.Add(new SelectListItem
                            {
                                Text = "پکیج " + neededMoney3 / 10 + " تومانی",
                                Value = "3"
                            });

                        }

                    }
                    else
                    {
                        UserChallengesOptions.Add(new SelectListItem
                        {
                            Text = "پکیج " + neededMoney1 / 10 + " تومانی",
                            Value = "1"
                        });
                        UserChallengesOptions.Add(new SelectListItem
                        {
                            Text = "پکیج " + neededMoney2 / 10 + " تومانی",
                            Value = "2"
                        });
                        UserChallengesOptions.Add(new SelectListItem
                        {
                            Text = "پکیج " + neededMoney3 / 10 + " تومانی",
                            Value = "3"
                        });
                    }

                }
                else
                {

                    preDefinedChallenge.TheName = theUser.Name;
                    preDefinedChallenge.TheFamily = theUser.Family;
                    preDefinedChallenge.TheMobileNumber = theUser.Cellphone;


                    UserChallengesOptions.Add(new SelectListItem
                    {
                        Text = "پکیج " + neededMoney1 / 10 + " تومانی",
                        Value = "1"
                    });
                    UserChallengesOptions.Add(new SelectListItem
                    {
                        Text = "پکیج " + neededMoney2 / 10 + " تومانی",
                        Value = "2"
                    });
                    UserChallengesOptions.Add(new SelectListItem
                    {
                        Text = "پکیج " + neededMoney3 / 10 + " تومانی",
                        Value = "3"
                    });
                }





                //// check validity to attend in new challenge
                //NeededMoneyToAttendInChallenge = Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge").ConstantValue);
                //DeadlineDays = Convert.ToInt32(_usersServices.GetConstantDictionary("expire_dates_for_challenge").ConstantValue);
                //int MaximumShareToReceive = Convert.ToInt32(_usersServices.GetConstantDictionary("maximum_number_of_prize_payment").ConstantValue);
                //long PrizePerShare = Convert.ToInt64(_usersServices.GetConstantDictionary("prize_for_invite_to_challenge").ConstantValue);
                ////MaximumPrize = (PrizePerShare * MaximumShareToReceive).ToString();
                //MaximumPrize = string.Format("{0:C}", (PrizePerShare * MaximumShareToReceive)).Replace("$", "").Replace(".00", "");

                //if (Convert.ToInt64(Amount) >= NeededMoneyToAttendInChallenge)
                //{
                //    Graphs graphUser = _usersServices.GetAllGraphs().Where(g => g.User == creatorID).FirstOrDefault();
                //    if (graphUser == null)
                //    {
                //        IsValidToChallenge = true;

                //        preDefinedChallenge.TheName = theUser.Name;
                //        preDefinedChallenge.TheFamily = theUser.Family;
                //        preDefinedChallenge.TheMobileNumber = theUser.Cellphone;
                //    }
                //    else
                //    {
                //        HasChallenge = true;
                //        ShareReceivedUntilNow = _usersServices.GetAllGraphHistoryData().Where(g => g.ToUser == creatorID).ToList().Count;
                //        DirectInviteds = _usersServices.GetAllGraphs().Where(g => g.Parent == creatorID).ToList().Count;
                //        RemainingDays = Convert.ToInt32((graphUser.ExpireDate - DateTime.Today).TotalDays);
                //    }
                //}
                //else
                //{
                //    Graphs graphUser = _usersServices.GetAllGraphs().Where(g => g.User == creatorID).FirstOrDefault();
                //    if (graphUser != null)
                //    {
                //        HasChallenge = true;
                //        ShareReceivedUntilNow = _usersServices.GetAllGraphHistoryData().Where(g => g.ToUser == creatorID).ToList().Count;
                //        DirectInviteds = _usersServices.GetAllGraphs().Where(g => g.Parent == creatorID).ToList().Count;
                //        RemainingDays = Convert.ToInt32((graphUser.ExpireDate - DateTime.Today).TotalDays);
                //    }
                //}

            }
        }


        void AddPaymentToUser(int[] orders, int sharedReceived, Guid userId, GraphHistory graphHistory, int graphType)
        {
            int maxShareToPayment = Convert.ToInt32(_usersServices.GetConstantDictionary("maximum_number_of_prize_payment_" + graphType).ConstantValue);
            if (sharedReceived > maxShareToPayment)
            {
                return;
            }

            int currentOrder = -1;
            long aggregateOrder = 0;
            for (int i = 0; i < orders.Length; i++)
            {
                aggregateOrder += orders[i];
                if (sharedReceived == aggregateOrder)
                {
                    currentOrder = orders[i];
                    break;
                }
            }

            if (currentOrder == -1)
            {
                if (sharedReceived > orders[orders.Length - 1])
                {
                    if (sharedReceived % orders[orders.Length - 1] == 0)
                    {
                        currentOrder = orders[orders.Length - 1];
                    }

                }
            }

            if (currentOrder != -1)
            {
                long paymentValue = currentOrder * Convert.ToInt64(_usersServices.GetConstantDictionary("prize_for_invite_to_challenge_" + graphType).ConstantValue);

                _usersServices.AddTransactionPercent(new TransactionPercents
                {
                    Created = DateTime.Now,
                    FromUser = graphHistory.User,
                    ToUser = graphHistory.ToUser,
                    FromAmount = paymentValue,
                    ToAmount = paymentValue,
                    Percentage = -2,
                    ReferenceID = graphHistory.Id.ToString(),
                    Transaction = graphHistory.Graph,
                    Description = "جایزه ثبت نام پکیچ ویژه نوع " + graphType + " " + _usersServices.GetUser(graphHistory.User).Username

                });

                Users theUser = _usersServices.GetUser(graphHistory.ToUser);
                theUser.Money += paymentValue;
                _usersServices.UpdateUser(theUser);
            }

        }


        public IActionResult OnPostTakeMoney(AddChallenge addChallenge)
        {
            InitiateValidations();

            if (HasHistory ^ ModelState.IsValid)
            {



                // get current user
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Users theUser = _usersServices.GetUser(creatorID);
                Graphs theParentGraph = null;
                if (ChallengeModeIndex == 1)
                {
                    NeededMoneyToAttendInChallenge = neededMoney1;
                }
                if (ChallengeModeIndex == 2)
                {
                    NeededMoneyToAttendInChallenge = neededMoney2;
                }
                if (ChallengeModeIndex == 3)
                {
                    NeededMoneyToAttendInChallenge = neededMoney3;
                }

                // check validity to challenge
                if (theUser != null && theUser.Money >= NeededMoneyToAttendInChallenge)
                {
                    // initiate required data
                    Users theParentUser = _usersServices.GetAllUsers().Where(u => u.Username == addChallenge.Parent).FirstOrDefault();
                    Guid? theGrandParentUser = null;
                    bool isFirstChildOfParent = true;
                    int addedDaysToExpireGraph = Convert.ToInt32(_usersServices.GetConstantDictionary("expire_dates_for_challenge_" + ChallengeModeIndex.ToString()).ConstantValue);


                    // if parent user is not null
                    if (theParentUser != null)
                    {
                        //theParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theParentUser.Id && g.ExpireDate > DateTime.Today.AddDays(-1 * addedDaysToExpireGraph)).FirstOrDefault();
                        theParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theParentUser.Id && g.GraphTypeIndex == ChallengeModeIndex).FirstOrDefault();
                        if (theParentGraph == null)
                        {
                            ResultMessage = "نام کاربری معرف اشتباه است.";
                            return Page();
                        }

                        // check if parent has another child 
                        if (_usersServices.GetAllGraphs().Where(g => g.Parent == theParentUser.Id && g.GraphTypeIndex == ChallengeModeIndex).FirstOrDefault() != null)
                        {
                            //parent has not any child
                            isFirstChildOfParent = false;
                            theGrandParentUser = theParentGraph.GrandParent;
                        }
                        else
                        {
                            if (theParentGraph.GrandParent != theParentGraph.User)
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
                        ReceivedShared = 0,
                        GraphTypeIndex = ChallengeModeIndex

                    };

                    _usersServices.AddGraph(newGraph);


                    string _orderOfPayments = _usersServices.GetConstantDictionary("order_of_prize_payment_" + ChallengeModeIndex.ToString()).ConstantValue;
                    string[] tmpArray = _orderOfPayments.Split(',').ToArray();
                    List<int> tmpList = new List<int>();

                    for (int i = 0; i < tmpArray.Length; i++)
                    {
                        tmpList.Add(Convert.ToInt32(tmpArray[i]));
                    }
                    int[] orderOfPayments = tmpList.ToArray();


                    // add prize to parent if this is not first child
                    if (theParentUser != null && isFirstChildOfParent == false)
                    {
                        if (theParentGraph.ExpireDate > DateTime.Today)
                        {
                            theParentGraph.ReceivedShared += 1;
                            _usersServices.UpdateGraph(theParentGraph);
                            GraphHistory _graphHistory = new GraphHistory
                            {
                                Created = DateTime.Now,
                                User = creatorID,
                                ToUser = theParentUser.Id,
                                Graph = newGraph.Id,
                                GraphModeIndex = ChallengeModeIndex
                            };
                            _usersServices.AddGraphHistory(_graphHistory);

                            AddPaymentToUser(orderOfPayments, theParentGraph.ReceivedShared, theParentUser.Id, _graphHistory, Convert.ToInt32(ChallengeModeIndex));
                        }



                    }


                    // add prize to grand father if exist
                    if (theGrandParentUser != null && isFirstChildOfParent && theGrandParentUser != creatorID)
                    {
                        //Graphs theGrandParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theGrandParentUser && g.ExpireDate > DateTime.Today.AddDays(-1 * addedDaysToExpireGraph)).FirstOrDefault();
                        Graphs theGrandParentGraph = _usersServices.GetAllGraphs().Where(g => g.User == theGrandParentUser && g.ExpireDate > DateTime.Today && g.GraphTypeIndex == ChallengeModeIndex).FirstOrDefault();
                        if (theGrandParentGraph != null)
                        {
                            theGrandParentGraph.ReceivedShared += 1;
                            _usersServices.UpdateGraph(theGrandParentGraph);

                            GraphHistory _graphHistory = new GraphHistory
                            {
                                Created = DateTime.Now,
                                Graph = newGraph.Id,
                                User = creatorID,
                                ToUser = Guid.Parse(theGrandParentUser.ToString()),
                                GraphModeIndex = ChallengeModeIndex
                            };

                            _usersServices.AddGraphHistory(_graphHistory);

                            AddPaymentToUser(orderOfPayments, theGrandParentGraph.ReceivedShared, theParentUser.Id, _graphHistory, Convert.ToInt32(ChallengeModeIndex));
                        }

                    }



                    if (_usersServices.GetAllChallengeUserData().Where(ud => ud.User==theUser.Id && ud.ChallengeModeIndex==ChallengeModeIndex).ToList<ChallengeUserData>().Count == 0)
                    {
                        if (HasHistory)
                        {
                            ChallengeUserData historyChallengeUserData = _usersServices.GetAllChallengeUserData().Where(ud => ud.User==theUser.Id).FirstOrDefault();
                            historyChallengeUserData.ChallengeModeIndex = ChallengeModeIndex;
                            historyChallengeUserData.Id = Guid.NewGuid();
                            _usersServices.AddChallengeUserData(historyChallengeUserData);
                        }
                        else
                        {
                            _usersServices.AddChallengeUserData(new ChallengeUserData
                            {
                                Cellphone = addChallenge.TheMobileNumber,
                                BirthDate = addChallenge.TheBirthDate,
                                Name = addChallenge.TheName,
                                Family = addChallenge.TheFamily,
                                FatherName = addChallenge.TheFatherName,
                                IdentityID = addChallenge.TheIDNumber,
                                NationalID = addChallenge.TheNationalID,
                                IsMarried = (addChallenge.IsMarried == 2) ? false : true,
                                User = creatorID,
                                Graph = newGraph.Id,
                                Created = DateTime.Now,
                                Username = theUser.Username,
                                IsExported = false,
                                ChallengeModeIndex = ChallengeModeIndex

                            });
                        }

                    }





                    _usersServices.AddTransaction(new Transactions
                    {
                        Amount = -1 * NeededMoneyToAttendInChallenge,
                        Created = DateTime.Now,
                        ReferenceID = newGraph.Id.ToString(),
                        Status = "خرید پک ویژه تبلیغاتی نوع " + ChallengeModeIndex.ToString(),
                        User = creatorID
                    });

                    theUser.Money -= NeededMoneyToAttendInChallenge;
                    theUser.Credits += NeededMoneyToAttendInChallenge;
                    _usersServices.UpdateUser(theUser);

                    ResultMessage = "ثبت شد.";
                    ResultMessageSuccess = "success";

                    IsValidToChallenge = false;
                    HasChallenge = true;

                    return Page();

                }
            }

            return Page();
        }
    }
}
