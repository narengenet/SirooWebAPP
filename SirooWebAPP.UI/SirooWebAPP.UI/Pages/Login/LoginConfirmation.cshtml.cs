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


        public LoginConfirmationModel(CustomIDataProtection customIDataProtection, IUserServices services)
        {
            _usersServices = services;
            protector = customIDataProtection;

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

        public IActionResult OnPostCofirmCode(Confirmed confirmed)
        {

            Users user = _usersServices.GetNotDeletedUser(confirmed.UserID);
            if (confirmed.ConfirmationCode == user.ConfirmationCode /*&& user.IsActivated*/)
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


            ViewData["userid"] = confirmed.UserID;
            return Page();
        }
    }
}
