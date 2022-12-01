using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class DeletedUsersModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public DeletedUsersModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }
        [BindProperty]
        public List<Users> DelUsers { get; set; }
        public void OnGet()
        {
            DelUsers=_usersServices.GetAllDeletedUsers();
        }
    }
}
