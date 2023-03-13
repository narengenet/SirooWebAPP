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
        public int? TheFollowings{ get; set; }
        public int? TheFollowers{ get; set; }
        public bool AmIFollowedBefore{ get; set; }
        public Guid ProfileUserId { get; set; }

        public string? DiamondCountList { get; set; }

        public void OnGet()
        {
            AmIFollowedBefore = false;
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
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);

            Users profilesUser = _usersServices.GetUserByUsername(ProfilesUsername);
            if (profilesUser != null)
            {
                if (profilesUser.ShowMyFullNameInPublic==true)
                {
                    ProfilesFullName = profilesUser.FullName();
                }
                else
                {
                    ProfilesFullName = "";
                }

                ProfilesAllPosts = CachedContents.Advertises.Where(ads => ads.Owner == profilesUser.Id).ToList<Advertise>().Count;
                TheFollowers = CachedContents.Followers.Where(f=>f.FollowedPerson==profilesUser.Id).ToList<Followers>().Count;
                TheFollowings = CachedContents.Followers.Where(f=>f.FollowPerson==profilesUser.Id).ToList<Followers>().Count;
                AmIFollowedBefore = CachedContents.Followers.Where(f => f.FollowedPerson == profilesUser.Id && f.FollowPerson == creatorID).FirstOrDefault() == null ? false : true;
                ProfilesUsername = profilesUser.Username;
                ProfilesMediaURL = profilesUser.ProfileMediaURL;
                ProfileUserId = profilesUser.Id;

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
