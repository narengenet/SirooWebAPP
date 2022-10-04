using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;

namespace SirooWebAPP.UI.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;


        public LoginModel(CustomIDataProtection customIDataProtection, IUserServices services)
        {
            _usersServices = services;
            protector = customIDataProtection;

        }
        public void OnGet()
        {
        }
        [BindProperty]
        public string ResultMessage { get; set; }

        [BindProperty]
        public LoginPerson? LoginPerson { get; set; }

        public IActionResult OnPostLogin(LoginPerson loginPerson)
        {

            Users _loginUser = _usersServices.GetUserByCellphone(loginPerson.Cellphone);
            if (_loginUser != null)
            {
                //if (_loginUser.IsActivated)
                //{
                    Random r = new Random();
                    int _confirmationCode = r.Next(1000, 9999);
                    _loginUser.ConfirmationCode = _confirmationCode.ToString();
                    _usersServices.UpdateUser(_loginUser);

                    return RedirectToPage("LoginConfirmation", "Display", new { UserID = _loginUser.Id });
                //}
                //else
                //{
                //    ResultMessage = $"{_loginUser.Cellphone} فعال نشده است.";
                //}

            }
            else
            {
                ResultMessage = $"{loginPerson.Cellphone} ثبت نشده است.";
            }



            return Page();

        }
    }
}
