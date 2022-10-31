using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages
{
    public class SampleAsyncSuperAdminsLoginFilter : IAuthorizationFilter
    {
        private readonly IUserServices _usersServices;

        public SampleAsyncSuperAdminsLoginFilter(IUserServices userServices)
        {
            _usersServices = userServices;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // read cookies if user has an online record in context device or not
            string tmpUserID = (HelperFunctions.GetCookie("userid", context.HttpContext.Request) != null) ? HelperFunctions.GetCookie("userid", context.HttpContext.Request) : null;
            string tmpUserToken = (HelperFunctions.GetCookie("usertoken", context.HttpContext.Request) != null) ? HelperFunctions.GetCookie("usertoken", context.HttpContext.Request) : null;

            // user has an online record cookie in his current device
            if (tmpUserID != null && tmpUserToken != null)
            {

                Guid usrid = Guid.Parse("00000000-0000-0000-0000-000000000000");
                try
                {
                    usrid = Guid.Parse(tmpUserID);
                }
                catch (Exception e)
                {
                    HelperFunctions.RemoveCookie("userid", context.HttpContext.Request, context.HttpContext.Response);
                    HelperFunctions.RemoveCookie("usertoken", context.HttpContext.Request, context.HttpContext.Response);
                    context.HttpContext.Session.SetString("userid", "00000000-0000-0000-0000-000000000000");
                    context.HttpContext.Session.SetString("userrolename", "anonymous");
                    throw;
                }

                if (usrid.ToString() != "00000000-0000-0000-0000-000000000000")
                {
                    // check online status of user with his user ID and token in his device cookies
                    if (_usersServices.CheckUserLogin(usrid, tmpUserToken))
                    {
                        // user is valid and have online record in DB then set his session
                        context.HttpContext.Session.SetString("userid", usrid.ToString());
                        // check if user role is super admin or not
                        Roles usrRole = _usersServices.GetUserRoles(usrid).OrderBy(u => u.Priority).First();

                        // set user details in session
                        Users _currentUser = _usersServices.GetUser(usrid);
                        // user is valid and have online record in DB then set his session
                        context.HttpContext.Session.SetString("userid", usrid.ToString());
                        context.HttpContext.Session.SetString("username", _currentUser.Username);
                        context.HttpContext.Session.SetString("userfullname", _currentUser.FullName());
                        context.HttpContext.Session.SetString("userrolename", usrRole.RoleName);
                        context.HttpContext.Session.SetString("userroledescription", usrRole.RoleDescription);

                        context.HttpContext.Session.SetString("userprofileurl", _currentUser.ProfileMediaURL);
                        context.HttpContext.Session.SetString("userpoints", _currentUser.Points.ToString());
                        context.HttpContext.Session.SetString("usercredits", _currentUser.Credits.ToString());


                        if (usrRole.RoleName != "super")
                        {
                            if (usrRole.RoleName != "admin")
                            {
                                context.Result = new RedirectResult("/Clients/Main");
                            }
                            
                        }


                    }
                    else
                    {
                        // user hasn't any valid online record in DB, then remove his/her current cookies record from current device
                        HelperFunctions.RemoveCookie("userid", context.HttpContext.Request, context.HttpContext.Response);
                        HelperFunctions.RemoveCookie("usertoken", context.HttpContext.Request, context.HttpContext.Response);
                        context.HttpContext.Session.SetString("userid", "00000000-0000-0000-0000-000000000000");
                        context.HttpContext.Session.SetString("userrolename", "anonymous");
                        context.Result = new RedirectToActionResult("", "gologin", 1);
                    }
                }
            }
            else
            {
                // user hasn't online record in his/her device's cookies
                //context.HttpContext.Session.SetString("userid", "-1");
                HelperFunctions.RemoveCookie("userid", context.HttpContext.Request, context.HttpContext.Response);
                HelperFunctions.RemoveCookie("usertoken", context.HttpContext.Request, context.HttpContext.Response);
                context.HttpContext.Session.SetString("userrolename", "anonymous");
                context.Result = new RedirectToActionResult("", "gologin", 1);
            }
        }
    }
}



