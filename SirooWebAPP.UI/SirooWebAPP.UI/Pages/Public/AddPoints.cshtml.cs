using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Public
{
    public class AddPointsModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        

        public AddPointsModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session= httpContextAccessor.HttpContext.Session;
            

        }
        public void OnGet()
        {
            string inviter = Request.Query["store"].ToString();
            if (inviter!=null)
            {
                Guid storeId = Guid.Parse(inviter);
                Users storeUser= _usersServices.GetUser(storeId);
                if (storeUser!=null)
                {
                    Roles storeRole= _usersServices.GetUserRoles(storeId).OrderBy(r => r.Priority).First();
                    if (storeRole.RoleName=="store")
                    {
                        this.session.SetString("store_donate", inviter);

                        HelperFunctions.SetCookie("store_donate", inviter, 1, HttpContext.Response);
                    }
                }
            }
            RedirectToPage("~/Client/Main");
        }
    }
}
