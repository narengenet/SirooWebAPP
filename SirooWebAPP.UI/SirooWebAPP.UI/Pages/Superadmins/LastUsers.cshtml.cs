using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class LastUsersModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public LastUsersModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }
        [BindProperty]
        public List<Users> NewUsers { get; set; }
        [BindProperty]
        public List<Users> OldUsers { get; set; }
        public void OnGet()
        {
            NewUsers= _usersServices.GetNotDeletedUsers().OrderByDescending(u=>u.Created).ToList<Users>();
            

        }
    }
}
