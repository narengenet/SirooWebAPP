using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages
{
    public class ConfirmationModel : PageModel
    {

        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;



        public ConfirmationModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;

        }




        [BindProperty(Name ="UserID",SupportsGet =true)]
        public Guid? UserID { get; set; }
        [BindProperty]
        public Confirmed? Confirmed { get; set; }
        public void OnGet()
        {
        }
        public void OnGetDisplay()
        {
            var sina = UserID;
            ViewData["userid"] = UserID;
        }

        public IActionResult OnPostCofirmCode(Confirmed confirmed)
        {
            if (ModelState.IsValid)
            {
                Users user= _usersServices.GetUser(confirmed.UserID);
                if (confirmed.ConfirmationCode==user.ConfirmationCode)
                {
                    // add client reward point for his registration
                    long _client_registration_reward = Convert.ToInt64(_usersServices.GetConstantDictionary("def_points_for_client_registration").ConstantValue);
                    user.Points = _client_registration_reward;

                    // activate user
                    user.IsActivated = true;
                    _usersServices.UpdateUser(user);

                    string guid = Guid.NewGuid().ToString();
                    string headeragent = Request.Headers["User-Agent"];
                    OnlineUsers _onlineUser = new OnlineUsers { User = user.Id, Guid = guid, LastCheckin = DateTime.Now, UserDevice = headeragent };
                    _usersServices.RegisterdSuccessfullyAndLogin(_onlineUser);

                    // check if inviter was a store
                    string? storeId= session.GetString("store_donate");
                    if (storeId!=null)
                    {
                        Users inviter_store= _usersServices.GetUser(Guid.Parse(storeId));

                        // get default reward for store as an inviter
                        long _inviter_reward = Convert.ToInt64(_usersServices.GetConstantDictionary("credit_for_client_registration_by_store_invitation").ConstantValue);
                        
                        // add store reward to his/her credits
                        inviter_store.Credits += _inviter_reward;
                        _usersServices.UpdateUser(inviter_store);
                    }
                    else
                    {
                        // if inviter was not a store then reward invitor points (not credit)
                        if (user.Inviter!=null)
                        {
                            long def_points_for_client_invitation = Convert.ToInt64(_usersServices.GetConstantDictionary("def_points_for_client_invitation").ConstantValue);
                            Guid _inviterId = Guid.Parse(user.Inviter.ToString());
                            Users _inviter = _usersServices.GetUser(_inviterId);
                            _inviter.Points += def_points_for_client_invitation;
                            _usersServices.UpdateUser(_inviter);
                        }
                    }
                    


                    HelperFunctions.RemoveCookie("userid", Request, Response);
                    HelperFunctions.SetCookie("userid", user.Id.ToString(), 365, Response);
                    HelperFunctions.SetCookie("usertoken", guid, 365, Response);
                    return RedirectToPage("/Clients/Main");
                }

            }
            ViewData["userid"] = confirmed.UserID;
            return Page();
        }
    }
}
