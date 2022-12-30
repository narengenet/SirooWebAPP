using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class AllSettingsModel : PageModel
    {


        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public AllSettingsModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }


        [BindProperty]
        public List<ConstantDictionaries> constantDics { get; set; }

        public void OnGet()
        {
            List<ConstantDictionaries> consts=_usersServices
                .GetAllConstantDictionaries()
                .OrderBy(d=>d.PriorityIndex)
                .ToList<ConstantDictionaries>();
            constantDics = consts;
        }
    }
}
