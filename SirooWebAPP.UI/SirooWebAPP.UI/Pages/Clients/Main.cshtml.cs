using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.Infrastructure.Services;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages
{
    public class MainModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public MainModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }

        public string? RoleName { get; set; }
        public string? MyUsername { get; set; }
        public string? MyPoints { get; set; }

        public string? DiamondCountList { get; set; }

        public void OnGet()
        {
            CheckDonationStatus();
            RoleName = session.GetString("userrolename");
            MyUsername = session.GetString("username");
            //MyPoints = session.GetString("userpoints");
            MyPoints = session.GetString("userdiamonds");


            if (CachedContents.DiamondPriorities.Count < 2)
            {
                ConstantDictionaries firstDic = _usersServices.GetConstantDictionary("diamond_first_priority");
                ConstantDictionaries secondDic = _usersServices.GetConstantDictionary("diamond_second_priority");
                ConstantDictionaries thirdDic = _usersServices.GetConstantDictionary("diamond_third_priority");
                ConstantDictionaries fourthDic = _usersServices.GetConstantDictionary("diamond_fourth_priority");
                ConstantDictionaries fivthDic = _usersServices.GetConstantDictionary("diamond_fivth_priority");
                ConstantDictionaries sixthDic = _usersServices.GetConstantDictionary("diamond_sixth_priority");
                ConstantDictionaries seventhDic = _usersServices.GetConstantDictionary("diamond_seventh_priority");
                ConstantDictionaries eighthDic = _usersServices.GetConstantDictionary("diamond_eighth_priority");
                ConstantDictionaries ninethDic = _usersServices.GetConstantDictionary("diamond_nineth_priority");
                ConstantDictionaries tenthDic = _usersServices.GetConstantDictionary("diamond_tenth_priority");

                CachedContents.DiamondCounts.Add(Convert.ToString(firstDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(firstDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(secondDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(secondDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(thirdDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(thirdDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(fourthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(fourthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(fivthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(fivthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(sixthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(sixthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(seventhDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(seventhDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(eighthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(eighthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(ninethDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(ninethDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(tenthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(tenthDic.ConstantSecondValue));

                for (int i = 0; i < CachedContents.DiamondPriorities.Count; i++)
                {
                    if (CachedContents.DiamondPriorities[i] > 0)
                    {
                        List<string> tmpListDiamondsCount = CachedContents.DiamondCounts[i].Split(",").ToList<string>();
                        foreach (string item in tmpListDiamondsCount)
                        {
                            CachedContents.DiamondCountsList.Add(item);
                        }
                    }
                }
            }

            DiamondCountList = Newtonsoft.Json.JsonConvert.SerializeObject(CachedContents.DiamondCountsList);

            



        }
        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";

        void CheckDonationStatus()
        {
            // check session for donnation data
            string? storeDonation = session.GetString("store_donate");
            string? ticketDonation = session.GetString("ticket_donate");
            
            // if session was null check cookies for donnation data
            if (storeDonation == null)
            {
                storeDonation = HelperFunctions.GetCookie("store_donate", Request);
                ticketDonation = HelperFunctions.GetCookie("ticket_donate", Request);
            }

            // if donnation was applicable
            if (storeDonation != null && ticketDonation != null)
            {
                Guid storeId = Guid.Parse(storeDonation);
                Guid ticketId = Guid.Parse(ticketDonation);
                Users storeUser = _usersServices.GetUser(storeId);
                DonnationTickets storeTicket = _usersServices.GetDonnationTicket(ticketId);
                if (storeUser != null && storeTicket != null)
                {
                    if (!storeUser.DonnationActive)
                    {
                        ResultMessage = "قابلیت دریافت امتیاز توسط فروشگاه غیر فعال است.";
                        clearTicketFootPrint();
                        return;
                    }

                    // get current user
                    string _creatorId = HelperFunctions.GetCookie("userid", Request);
                    Guid creatorID = Guid.Parse(_creatorId);
                    if (storeId == creatorID)
                    {
                        ResultMessage = "امکان استفاده از امتیاز برای خود وجود ندارد.";
                        clearTicketFootPrint();
                        return;
                    }


                    //check if ticket has capacity
                    if (storeTicket.IsDeleted)
                    {
                        ResultMessage = "کارت هدیه توسط هدیه دهنده حذف شده است.";
                        clearTicketFootPrint();
                        return;
                    }

                    // check if donner is a store or not
                    Roles storeRole = _usersServices.GetUserRoles(storeId).OrderBy(r => r.Priority).First();
                    if (storeRole.RoleName != "store")
                    {
                        ResultMessage = "امکان استفاده از امتیاز وجود ندارد.";
                        clearTicketFootPrint();
                        return;
                    }



                    //check if ticket has capacity
                    if (storeTicket.RemainedCapacity == 0)
                    {
                        ResultMessage = "ظرفیت استفاده از این کارت هدیه به اتمام رسیده است.";
                        clearTicketFootPrint();
                        return;
                    }

                    // check if store has enough credit to donate of not
                    if (storeTicket.Value > storeUser.Credits)
                    {
                        ResultMessage = "فروشگاه مورد نظر اعتبار کافی برای هدیه به شما را ندارد.";
                        clearTicketFootPrint();
                        return;
                    }

                    int usagePerDay = Convert.ToInt32(_usersServices.GetConstantDictionary("store_point_usage_per_day").ConstantValue);
                    int maxStoreDonationPoint = Convert.ToInt32(_usersServices.GetConstantDictionary("stores_max_donnation_point").ConstantValue);

                    if (storeTicket.Value >= maxStoreDonationPoint)
                    {
                        ResultMessage = "امتیاز تایین شده توسط فروشگاه بیشتر از حداکثر امتیاز تایین شده برای هدیه است.";
                        clearTicketFootPrint();
                        return;
                    }

                    List<PointUsages> todayClientUsageFromDonner = _usersServices.GetAllUsedPointByDonner(storeId).Where(p => p.Receiver == creatorID && p.Created.Value.DayOfYear == DateTime.Now.DayOfYear && p.Created.Value.Year == DateTime.Now.Year).ToList<PointUsages>();
                    if (todayClientUsageFromDonner.Count >= usagePerDay)
                    {
                        ResultMessage = "تعداد دفعات مجاز استفاده از هدایای این فروشگاه برای امروز تمام شده است.";
                        clearTicketFootPrint();
                        return;
                    }

                    // subtract donner's default credit than donner's credit 
                    storeUser.Credits -= storeTicket.Value;
                    _usersServices.UpdateUser(storeUser);
                    // add usage point to history
                    _usersServices.UsePoint(storeTicket.Id, storeId, creatorID, storeTicket.Value, false);
                    // get current user
                    Users currentUser = _usersServices.GetUser(creatorID);
                    // add donnation points to current user
                    currentUser.Points += storeTicket.Value;
                    _usersServices.UpdateUser(currentUser);
                    // subtract donner's ticket capacity
                    storeTicket.RemainedCapacity -= 1;
                    _usersServices.UpdateDonnationTicket(storeTicket);

                    string? _usrPoints= session.GetString("userpoints");
                    if (_usrPoints!=null)
                    {
                        double usrPoints = Convert.ToDouble(_usrPoints);
                        usrPoints += storeTicket.Value;
                        session.SetString("userpoints", usrPoints.ToString());
                    }

                    ResultMessage = "امتیاز هدیه دریافت شد.";
                    ResultMessageSuccess = "success";


                }
            }

            clearTicketFootPrint();


        }
        private void clearTicketFootPrint()
        {
            session.Remove("store_donate");
            session.Remove("ticket_donate");
            HelperFunctions.RemoveCookie("store_donate", Request, Response);
            HelperFunctions.RemoveCookie("ticket_donate", Request, Response);
        }
    }
}
