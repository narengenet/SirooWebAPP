using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.Infrastructure.Services;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class ProfilesModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public ProfilesModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }

        public string? RoleName { get; set; }
        public string? MyUsername { get; set; }
        public string? MyPoints { get; set; }

        public string? ProfilesUsername { get; set; }
        public string? ProfilesFullName { get; set; }
        public string? ProfilesMediaURL { get; set; }
        public int? ProfilesAllPosts{ get; set; }

        public string? DiamondCountList { get; set; }

        public void OnGet()
        {

            RoleName = session.GetString("userrolename");
            MyUsername = session.GetString("username");
            //MyPoints = session.GetString("userpoints");
            MyPoints = session.GetString("userdiamonds");

            ProfilesUsername= "";
            if (Request.Query["username"].Count != 0)
            {
                ProfilesUsername = Request.Query["username"];
            }
            else
            {
                ProfilesUsername = MyUsername;
            }

            InitializeProfiles();


        }


        private void InitializeProfiles()
        {
            
            Users profilesUser = _usersServices.GetUserByUsername(ProfilesUsername);
            if (profilesUser != null)
            {
                ProfilesFullName = profilesUser.FullName();
                ProfilesAllPosts = CachedContents.Advertises.Where(ads => ads.Owner == profilesUser.Id).ToList<Advertise>().Count;
                ProfilesUsername = profilesUser.Username;
                ProfilesMediaURL = profilesUser.ProfileMediaURL;

            }
            else
            {
                ProfilesUsername = "-1";
            }
        }
        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";


    }
}
