using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.Infrastructure.SMS;

namespace SirooWebAPP.UI.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;



        public LoginModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


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
                //Random r = new Random();
                //int _confirmationCode = r.Next(1000, 9999);
                //_loginUser.ConfirmationCode = _confirmationCode.ToString();
                _loginUser.LastModified = DateTime.Now;
                _usersServices.UpdateUser(_loginUser);

                // reset confirmation count session
                session.SetInt32("confirmationCount", 0);
#if DEBUG

#else
                //SMSSender.SendToPattern(_loginUser.Cellphone, _loginUser.FullName(), _loginUser.ConfirmationCode);
#endif
                return RedirectToPage("LoginConfirmation", "Display", new { UserID = _loginUser.Id , Username=_loginUser.Cellphone});
                //}
                //else
                //{
                //    ResultMessage = $"{_loginUser.Cellphone} فعال نشده است.";
                //}

            }
            else
            {
                ResultMessage = $"{loginPerson.Cellphone} غیر معتبر است.";
            }



            return Page();

        }
    }
}
