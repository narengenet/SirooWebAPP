using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class ChangePasswordModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;



        public ChangePasswordModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;

        }




        [BindProperty(Name = "UserID", SupportsGet = true)]
        public Guid? UserID { get; set; }
        [BindProperty]
        public ChangeThePassword? ChangeThePassword { get; set; }
        public void OnGet()
        {
            UserID = Guid.Parse(session.GetString("userid"));
            ViewData["userid"] = UserID;
        }
        public void OnGetDisplay()
        {
            var sina = UserID;
            ViewData["userid"] = UserID;
        }

        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";

        public IActionResult OnPostCofirmCode(ChangeThePassword changeThePassword)
        {
            if (ModelState.IsValid)
            {
                if (session.GetString("userid") == changeThePassword.UserID.ToString())
                {
                    Users usr= _usersServices.GetUser(changeThePassword.UserID);
                    if (usr.ConfirmationCode== changeThePassword.CurrentConfirmationCode)
                    {
                        usr.ConfirmationCode = changeThePassword.ConfirmationCode;
                        _usersServices.UpdateUser(usr);
                        
                        return RedirectToPage("/LogOut", "Display");
                    }
                    else
                    {
                        ResultMessage = "کلمه عبور فعلی اشتباه است.";
                    }
                }
                else
                {
                    ResultMessage = "شما امکان این تغییر را ندارید.";
                }


            }

            UserID = Guid.Parse(session.GetString("userid"));
            ViewData["userid"] = UserID;
            return Page();
        }
    }
}
