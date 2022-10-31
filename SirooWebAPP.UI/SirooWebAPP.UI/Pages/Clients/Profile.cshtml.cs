using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class ProfileModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;
        private readonly ISession session;
        private readonly IHttpContextAccessor _httpContextAccessor;




        public ProfileModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;
            session = httpContextAccessor.HttpContext.Session;
            _httpContextAccessor = httpContextAccessor;


        }
        public DTOUserProfile _currentUser = new DTOUserProfile();
        public string roleName = "anonymous";
        public string InvitationLink = "";

        public void OnGet()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            _currentUser = _usersServices.GetUserProfile(creatorID);
            roleName= session.GetString("userroledescription");
            InvitationLink = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value + "/Registeration/Register?inviter=" + _currentUser.Username;

        }
    }
}
