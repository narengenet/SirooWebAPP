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
    public class InsuranceModel : PageModel
    {

        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public InsuranceModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }


        public bool IsValidToChallenge = false;
        public bool HasChallenge = false;
        public bool HasPaid { get; set; }


        public long NeededMoneyToAttendInInsurance = 0;
        public bool IsSuccessfull { get; set; }
        //public int ShareReceivedUntilNow = 0;
        //public string MaximumPrize = "";
        //public int DirectInviteds = 0;
        //public int DeadlineDays = 0;
        //public int RemainingDays = 0;


        [BindProperty]
        public AddInsurance? AddInsurance { get; set; }


        public AddInsurance preDefinedInsurance;


        public string ResultMessage = "";
        public string ResultMessageSuccess = "danger";


        public int neededMoney1 = 0;
        //public int neededMoney2 = 0;
        //public int neededMoney3 = 0;

        public long currentMoney = 0;

        //public List<SelectListItem> UserChallengesOptions { get; set; }

        //[BindProperty]
        //public int? ChallengeModeIndex { get; set; }


        public void OnGet()
        {

            InitiateValidations();

        }

        public bool HasHistory { get; set; }
        public List<int?> ValidGraphHistoryAttended { get; set; }

        void InitiateValidations()
        {




            neededMoney1 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_insurance2").ConstantValue);




            // get current user
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);
            string Amount = "";



            if (theUser != null)
            {
                Amount = theUser.Money.ToString();
                currentMoney = theUser.Money;

                InsuranceUserData _tmpInsuranceUserData = _usersServices.GetAllInsuranceUserData().Where(x => x.User == theUser.Id).FirstOrDefault();
                if (_tmpInsuranceUserData != null)
                {
                    HasHistory = true;
                    return;
                }
                else
                {
                    HasHistory = false;
                    if (currentMoney >= neededMoney1)
                    {
                        NeededMoneyToAttendInInsurance = 0;
                        preDefinedInsurance = new AddInsurance();

                        preDefinedInsurance.TheMobileNumber = theUser.Cellphone;
                        preDefinedInsurance.TheName = theUser.Name;
                        preDefinedInsurance.TheFamily = theUser.Family;
                    }
                    else
                    {
                        NeededMoneyToAttendInInsurance = neededMoney1 - currentMoney;
                    }
                }



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


        public IActionResult OnPostAddUserData(AddInsurance addInsurance)
        {
            InitiateValidations();

            if (HasHistory ^ ModelState.IsValid)
            {
                // get current user
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Users theUser = _usersServices.GetUser(creatorID);

                string theMilitaryStatus = "";
                switch (addInsurance.TheMilitaryServiceStatus)
                {
                    case 1:
                        theMilitaryStatus = "انجام داده‌ام";
                        break;
                    case 2:
                        theMilitaryStatus = "انجام نداده‌ام";
                        break;
                    case 3:
                        theMilitaryStatus = "درحال خدمت";
                        break;
                    case 4:
                        theMilitaryStatus = "معافیت غیرپزشکی";
                        break;
                    case 5:
                        theMilitaryStatus = "معافیت پزشکی";
                        break;
                    default:
                        break;
                }

                Users parentUser = _usersServices.GetAllUsers().Where(u => u.Username == addInsurance.Parent).FirstOrDefault();
                if (parentUser == null)
                {
                    InitiateValidations();
                    ResultMessage = "نام کاربری معرف معتبر نیست.";
                    return Page();
                }
                else
                {

                    Roles parentRole = _usersServices.GetUserRoles(parentUser.Id).First();
                    if (parentRole.RoleName == "zoneadmin" || parentRole.RoleName == "marketer")
                    {
                        theUser.Money -= neededMoney1;
                        _usersServices.UpdateUser(theUser);

                        InsuranceUserData insuranceUserData = new InsuranceUserData
                        {
                            AddressCity = addInsurance.TheAddressCity,
                            AddressDetails = addInsurance.TheAddressDetails,
                            AddressPostalCode = addInsurance.TheAddressPostalCode,
                            AddressProvience = addInsurance.TheAddressProvience,
                            BirthDate = addInsurance.TheBirthDate,
                            Cellphone = addInsurance.TheMobileNumber,
                            Family = addInsurance.TheFamily,
                            Name = addInsurance.TheName,
                            FatherName = addInsurance.TheFatherName,
                            Weight = addInsurance.TheWeight,
                            Height = addInsurance.TheHeight,
                            FatherIsAlive = (addInsurance.TheFatherAlive == 1) ? true : false,
                            IdentityID = addInsurance.TheIDNumber,
                            NationalID = addInsurance.TheNationalID,
                            IsExported = false,
                            Gender = addInsurance.TheGender == 1 ? true : false,
                            IsMarried = addInsurance.IsMarried == 1 ? true : false,
                            IsPaid = true,
                            IssuePlace = addInsurance.TheIssuePlace,
                            JobTitle = addInsurance.TheJobTitle,
                            MotherIsAlive = addInsurance.TheMotherAlive == 1 ? true : false,
                            ResidentialPhone = addInsurance.TheResidentialPhone,
                            User = theUser.Id,
                            Username = theUser.Username,
                            Created = DateTime.Now,
                            MilitaryServiceStatus = theMilitaryStatus,
                            TheParent = parentUser.Id,
                             IsDeleted = false
                        };

                        _usersServices.AddInsuranceUserData(insuranceUserData);

                        _usersServices.AddTransaction(new Transactions
                        {
                            Amount = -1 * neededMoney1,
                            Created = DateTime.Now,
                            ReferenceID = insuranceUserData.Id.ToString(),
                            Status = "خرید پکیج تخفیف بیمه ای ",
                            User = theUser.Id
                        });

                        int prizeForMarketer = Convert.ToInt32(_usersServices.GetConstantDictionary("prize_marketer_to_invite_in_insurance2").ConstantValue);
                        int prizeForZoneadmin = Convert.ToInt32(_usersServices.GetConstantDictionary("prize_zoneadmin_to_invite_in_insurance2").ConstantValue);

                        if (parentRole.RoleName == "zoneadmin")
                        {
                            parentUser.Money += prizeForMarketer+ prizeForZoneadmin;
                            _usersServices.UpdateUser(parentUser);

                            _usersServices.AddTransactionPercent(new TransactionPercents
                            {
                                Created = DateTime.Now,
                                FromUser = theUser.Id,
                                ToUser = parentUser.Id,
                                FromAmount = prizeForMarketer + prizeForZoneadmin,
                                ToAmount = prizeForMarketer + prizeForZoneadmin,
                                Percentage = 0,
                                ReferenceID = insuranceUserData.Id.ToString(),
                                Transaction = insuranceUserData.Id,
                                Description = "پورسانت خرید پکیج بیمه و وام مهرامید توسط " + theUser.Username

                            });
                        }

                        if (parentRole.RoleName == "marketer")
                        {
                            parentUser.Money += prizeForMarketer;
                            _usersServices.UpdateUser(parentUser);

                            _usersServices.AddTransactionPercent(new TransactionPercents
                            {
                                Created = DateTime.Now,
                                FromUser = theUser.Id,
                                ToUser = parentUser.Id,
                                FromAmount = prizeForMarketer,
                                ToAmount = prizeForMarketer,
                                Percentage = 0,
                                ReferenceID = insuranceUserData.Id.ToString(),
                                Transaction = insuranceUserData.Id,
                                Description = "پورسانت خرید پکیج بیمه و وام مهرامید توسط " + theUser.Username

                            });

                            UsersRoles paretn_parent= _usersServices.GetAllUsersRoles().Where(x => x.User == parentUser.Id).FirstOrDefault();
                            Users parent_parentUser = _usersServices.GetUser(paretn_parent.CreatedBy);
                            parent_parentUser.Money += prizeForZoneadmin;
                            _usersServices.UpdateUser(parent_parentUser);

                            _usersServices.AddTransactionPercent(new TransactionPercents
                            {
                                Created = DateTime.Now,
                                FromUser = theUser.Id,
                                ToUser = parent_parentUser.Id,
                                FromAmount = prizeForZoneadmin,
                                ToAmount = prizeForZoneadmin,
                                Percentage = 0,
                                ReferenceID = insuranceUserData.Id.ToString(),
                                Transaction = insuranceUserData.Id,
                                Description = "پورسانت خرید پکیج بیمه و وام مهرامید توسط " + theUser.Username

                            });
                        }
                        IsSuccessfull = true;
                        ResultMessageSuccess = "success";
                        ResultMessage = "پکیج تخفیف بیمه شما با موفقیت ثبت شد.";
                    }
                    else
                    {
                        InitiateValidations();
                        ResultMessage = "نام کاربری معرف معتبر نیست.";
                        return Page();
                    }

 


                }


            }

            return Page();
        }
    }
}
