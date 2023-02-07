using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public List<SelectListItem> UserChallengesOptions { get; set; }

        [BindProperty]
        public int? ChallengeModeIndex { get; set; }


        public int neededMoney1 = 0;
        public int neededMoney2 = 0;
        public int neededMoney3 = 0;


        public ExportChallengeUserDataModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        public void OnGet()
        {
            UserChallengesOptions = new List<SelectListItem>();


            neededMoney1 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_1").ConstantValue);
            neededMoney2 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_2").ConstantValue);
            neededMoney3 = Convert.ToInt32(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_3").ConstantValue);


            UserChallengesOptions.Add(new SelectListItem
            {
                Text = "همه پکیج ها",
                Value = "0"
            });
            UserChallengesOptions.Add(new SelectListItem
            {
                Text = "پکیج " + neededMoney1 / 10 + " تومانی",
                Value = "1"
            });
            UserChallengesOptions.Add(new SelectListItem
            {
                Text = "پکیج " + neededMoney2 / 10 + " تومانی",
                Value = "2"
            });
            UserChallengesOptions.Add(new SelectListItem
            {
                Text = "پکیج " + neededMoney3 / 10 + " تومانی",
                Value = "3"
            });


            int selectedIndex = 0;
            if (Request.Query["challenge"] == "1" || Request.Query["challenge"] == "2" || Request.Query["challenge"] == "3")
            {
                UserChallengesOptions.Where(g => g.Value == Request.Query["challenge"]).FirstOrDefault().Selected = true;
                ChallengeModeIndex = Convert.ToInt32(Request.Query["challenge"]);
            }
            else
            {
                UserChallengesOptions[selectedIndex].Selected = true;
                ChallengeModeIndex = Convert.ToInt32(UserChallengesOptions[selectedIndex].Value);
            }

            if (ChallengeModeIndex==0)
            {
                newChallengeUserData = _usersServices.GetAllChallengeUserData().Where(cd => cd.IsExported != true).Count();
                allChallengeUserData = _usersServices.GetAllChallengeUserData().Count();
            }
            else
            {
                newChallengeUserData = _usersServices.GetAllChallengeUserData().Where(cd => cd.IsExported != true && cd.ChallengeModeIndex == ChallengeModeIndex).Count();
                allChallengeUserData = _usersServices.GetAllChallengeUserData().Where(cd => cd.ChallengeModeIndex == ChallengeModeIndex).Count();
            }

        }
    }
}
