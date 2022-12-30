using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class DrawsModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public DrawsModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }
        public string? RoleName { get; set; }
        public string? MyUsername { get; set; }
        public string? MyPoints { get; set; }
        public void OnGet()
        {
            RoleName = session.GetString("userrolename");
            MyUsername = session.GetString("username");
            //MyPoints = session.GetString("userpoints");
            MyPoints = session.GetString("userdiamonds");
        }
    }
}
