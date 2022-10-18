using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class PendingPostsModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public PendingPostsModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }

        public void OnGet()
        {

        }
        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";
    }
}
