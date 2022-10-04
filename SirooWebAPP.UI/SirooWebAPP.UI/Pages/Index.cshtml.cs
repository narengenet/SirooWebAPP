using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages
{
    public class AddResponseHeaderFilter : ActionFilterAttribute
    {
        // async method which can surround the action execution
        // invoked for both before and post execution of action
        public async override Task OnActionExecutionAsync(
            ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // access Request
            context.HttpContext.Response.Headers.Add(
            "X-MyCustomHeader", Guid.NewGuid().ToString());

            var result = await next.Invoke();

            // access Response
            Console.WriteLine(JsonConvert.SerializeObject(result.Result));
        }
    }


        public class IndexModel : PageModel
        {
            private readonly IUserServices _usersServices;
            private readonly CustomIDataProtection protector;
            private readonly ISession session;

            private readonly ILogger<IndexModel> _logger;


            public IndexModel(ILogger<IndexModel> logger, CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
            {
                _logger = logger;
                _usersServices = services;
                protector = customIDataProtection;
                this.session = httpContextAccessor.HttpContext.Session;

            }


            protected void OnInitialized()
            {
                string message = $"Initialized at {DateTime.Now}";
            }

            [BindProperty]
            public string FirstName { get; set; }

            [BindProperty]
            public string LastName { get; set; }

            public void OnPost()
            {
                var sina = 1;
                if (Request.Form != null)
                {
                    var username = Request.Form["username"];
                }
            }

        
        public IActionResult OnGet()
            {
                var abbas = session.GetString("userid");

                var sina = Request.Headers["User-Agent"];

                //if (abbas != "-1" && abbas!=null)
                //{
                //    Response.Redirect("/Clients/Main");
                //}
                //else
                //{
                //    Response.Redirect("/Login/Login");
                //}
            return Page();
                //string tmpUserID = (HelperFunctions.GetCookie("userid", Request) != null) ? HelperFunctions.GetCookie("userid", Request) : null;
                //string tmpUserToken= (HelperFunctions.GetCookie("usertoken", Request) != null) ? HelperFunctions.GetCookie("usertoken", Request) : null;
                //if (tmpUserID!=null && tmpUserToken!=null)
                //{
                //    int usrid = -1;
                //    try
                //    {
                //        usrid = Convert.ToInt32(tmpUserID);
                //    }
                //    catch (Exception e)
                //    {

                //        throw;
                //    }

                //    if (usrid>0)
                //    {
                //        if(_usersServices.CheckUserLogin(usrid, tmpUserToken)){
                //            Response.Redirect("/Clients/Main");
                //        }
                //        else
                //        {
                //            HelperFunctions.RemoveCookie("userid", Request, Response);
                //            HelperFunctions.RemoveCookie("usertoken", Request, Response);
                //        }
                //    }
                //}



                //if (HelperFunctions.GetCookie("sina",Request) != null)
                //{
                //    string sin = HelperFunctions.GetCookie("sina", Request).ToString();
                //}
                //else
                //{
                //    HelperFunctions.SetCookie("sina", "12345", 350000,Response);
                //}
            }
            public void Set(string key, string value, int? expireTime)
            {
                CookieOptions option = new CookieOptions();
                if (expireTime.HasValue)
                    option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
                else
                    option.Expires = DateTime.Now.AddMilliseconds(10);
                Response.Cookies.Append(key, value, option);
            }

        }
    }