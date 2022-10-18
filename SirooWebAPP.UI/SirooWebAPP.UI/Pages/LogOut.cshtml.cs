using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages
{
    public class LogOutModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;
        private readonly ISession session;


        public LogOutModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment,IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;
            session = httpContextAccessor.HttpContext.Session;


        }
        public void OnGet()
        {
            string userid= HelperFunctions.GetCookie("userid", Request);
            string guid = HelperFunctions.GetCookie("usertoken", Request);
            if (userid!=null && guid!=null)
            {
                Guid userID = Guid.Parse(userid);
                _usersServices.LogOut(userID, guid);
            }
            HelperFunctions.RemoveCookie("userid",Request, Response);
            HelperFunctions.RemoveCookie("usertoken", Request, Response);
            session.Remove("store_donate");
            session.Remove("ticket_donate");
            HelperFunctions.RemoveCookie("store_donate", Request, Response);
            HelperFunctions.RemoveCookie("ticket_donate", Request, Response);
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            session.Clear();

        }
    }
}
