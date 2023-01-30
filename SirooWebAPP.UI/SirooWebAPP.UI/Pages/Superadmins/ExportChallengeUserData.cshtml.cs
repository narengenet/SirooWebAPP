using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class ExportChallengeUserDataModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;



        public int allChallengeUserData = 0;
        public int newChallengeUserData = 0;


        public ExportChallengeUserDataModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        public void OnGet()
        {
            newChallengeUserData= _usersServices.GetAllChallengeUserData().Where(cd => cd.IsExported != true).Count();
            allChallengeUserData= _usersServices.GetAllChallengeUserData().Count();
        }
    }
}
