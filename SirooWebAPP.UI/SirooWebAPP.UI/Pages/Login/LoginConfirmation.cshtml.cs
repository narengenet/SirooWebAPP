using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages
{
    public class LoginConfirmationModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;

        public LoginConfirmationModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;
        }

        [BindProperty(Name = "UserID", SupportsGet = true)]
        public Guid? UserID { get; set; }
        [BindProperty]
        public Confirmed? Confirmed { get; set; }

        public void OnGetDisplay()
        {
            var sina = UserID;
            ViewData["userid"] = UserID;
        }
        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";

        public IActionResult OnPostCofirmCode(Confirmed confirmed)
        {

            Users user = _usersServices.GetNotDeletedUser(confirmed.UserID);

#if DEBUG
            if (confirmed.ConfirmationCode == user.ConfirmationCode || confirmed.ConfirmationCode=="5130" /* ***temp***  */)
#else
            if (confirmed.ConfirmationCode == user.ConfirmationCode)
#endif
            {
                string guid = Guid.NewGuid().ToString();
                string headeragent = Request.Headers["User-Agent"];
                OnlineUsers _onlineUser = new OnlineUsers { User = user.Id, Guid = guid, LastCheckin = DateTime.Now, UserDevice = headeragent };
                // check if user has not activated his/her account at registration, activate him/her at successful login
                if (!user.IsActivated)
                {
                    user.IsActivated = true;
                    _usersServices.UpdateUser(user);
                }
                _usersServices.LoginSuccessfully(_onlineUser);

                HelperFunctions.RemoveCookie("userid", Request, Response);
                HelperFunctions.SetCookie("userid", user.Id.ToString(), 365, Response);
                HelperFunctions.SetCookie("usertoken", guid, 365, Response);
                return RedirectToPage("/Clients/Main");

            }
            else
            {
                // confirmation code was not correct
                // read session to check how many times false confirmation code was entered
                int? __count = session.GetInt32("confirmationCount");
                int count = 0;
                if (__count != null)
                {
                    count = Convert.ToInt32(__count) + 1;
                    if (count == 3)
                    {
                        // 3 times incorrect confimation code was entered 
                        session.Remove("confirmationCount");
                        // redirect to register again
                        return RedirectToPage("/Login/Login");
                    }

                }

                ResultMessage = "کد تایید اشتباه است. تنها " + (3 - count).ToString() + " بار دیگر فرصت دارید.";
                session.SetInt32("confirmationCount", count);
            }


            ViewData["userid"] = confirmed.UserID;
            return Page();
        }
    }
}
