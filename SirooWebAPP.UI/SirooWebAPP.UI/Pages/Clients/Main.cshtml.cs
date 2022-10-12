using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
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

        public void OnGet()
        {
            CheckDonationStatus();
        }
        public string ResultMessage = "";

        void CheckDonationStatus()
        {
            string? storeDonation = session.GetString("store_donate");
            if (storeDonation == null)
            {
                storeDonation = HelperFunctions.GetCookie("store_donate", Request);
            }
            if (storeDonation != null)
            {
                Guid storeId = Guid.Parse(storeDonation);
                Users storeUser = _usersServices.GetUser(storeId);
                if (storeUser != null)
                {
                    if (!storeUser.DonnationActive)
                    {
                        ResultMessage = "قابلیت دریافت امتیاز توسط فروشگاه غیر فعال است.";
                        return;
                    }

                    // get current user
                    string _creatorId = HelperFunctions.GetCookie("userid", Request);
                    Guid creatorID = Guid.Parse(_creatorId);
                    if (storeId==creatorID)
                    {
                        ResultMessage = "امکان استفاده از امتیاز برای خود وجود ندارد.";
                        return;
                    }

                    // check if donner is a store or not
                    Roles storeRole = _usersServices.GetUserRoles(storeId).OrderBy(r => r.Priority).First();
                    if (storeRole.RoleName!="store")
                    {
                        ResultMessage = "امکان استفاده از امتیاز وجود ندارد.";
                        return;
                    }

                    // check if store has enough credit to donate of not
                    if (storeUser.DefaultCredit>storeUser.Credits)
                    {
                        ResultMessage = "فروشگاه مورد نظر اعتبار کافی برای هدیه به شما را ندارد.";
                        return;
                    }

                    int usagePerDay= Convert.ToInt32(_usersServices.GetConstantDictionary("store_point_usage_per_day").ConstantValue);
                    int maxStoreDonationPoint= Convert.ToInt32(_usersServices.GetConstantDictionary("stores_max_donnation_point").ConstantValue);
                    if (storeUser.DefaultCredit>maxStoreDonationPoint)
                    {
                        ResultMessage = "امتیاز تایین شده توسط فروشگاه بیشتر از حداکثر امتیاز تایین شده برای هدیه است.";
                        return;
                    }

                    List<PointUsages> todayClientUsageFromDonner= _usersServices.GetAllUsedPointByDonner(storeId).Where(p => p.Receiver == creatorID && p.Created.Value.DayOfYear == DateTime.Now.DayOfYear && p.Created.Value.Year==DateTime.Now.Year).ToList<PointUsages>();
                    if (todayClientUsageFromDonner.Count > usagePerDay)
                    {
                        ResultMessage = "تعداد دفعات مجاز استفاده از این هدیه برای امروز تمام شده است.";
                        return;
                    }

                    // subtract donner's default credit than donner's credit 
                    storeUser.Credits -= storeUser.DefaultCredit;
                    _usersServices.UpdateUser(storeUser);
                    // add usage point to history
                    _usersServices.UsePoint(storeId, creatorID, storeUser.DefaultCredit, false);
                    // get current user
                    Users currentUser = _usersServices.GetUser(creatorID);
                    // add donnation points to current user
                    currentUser.Points += storeUser.DefaultCredit;
                    _usersServices.UpdateUser(currentUser);

                    session.Remove("store_donate");
                    HelperFunctions.RemoveCookie("store_donate", Request, Response);


                }
            }

        }
    }
}
