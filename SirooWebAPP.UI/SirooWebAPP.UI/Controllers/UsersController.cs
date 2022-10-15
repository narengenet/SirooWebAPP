using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;

using SirooWebAPP.UI.Pages;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using IAuthorizationFilter = Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter;

namespace SirooWebAPP.UI.Controllers
{

    public class UsersController : Controller
    {
        private readonly IUserServices _usersServices;
        private readonly ISession session;

        public UsersController(IUserServices userServices)
        {
            _usersServices = userServices;
        }

        [HttpGet("rooli")]
        public IActionResult GetRole()
        {
            Roles roles = new Roles();
            roles.RoleName = "SuperAdmin";
            roles.IsActivated = true;
            roles.RoleDescription = "dessssss";
            roles.Created = DateTime.Now;
            //roles.CreatedBy = Guid.NewGuid().ToString();
            roles.LastModifiedBy = Guid.NewGuid().ToString();
            return Ok(_usersServices.AddRole(roles));


        }

        [HttpGet("sina/{userId:int}")]
        public IActionResult Get(Guid userId)
        {
            Users result = _usersServices.GetUser(userId);
            //_usersServices.GetUsernames();
            return Ok(result);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("person")]
        public IActionResult GetPerson()
        {
            User user = new User();
            user.name = "sina";
            user.id = 1;
            user.email = "s@a.com";
            user.website = "yahoo.com";
            user.phone = "+98939";
            User user2 = new User();
            user2.name = "sepideh";
            user2.id = 2;
            user2.email = "sep@id.eh";
            user2.website = "google.com";
            user2.phone = "+989163681249";

            List<User> res = new List<User>();
            res.Add(user);
            res.Add(user2);
            return Ok(res);
        }
        [HttpGet("gologin")]
        public IActionResult GoLogin(int userId)
        {
            return Ok("gologin");
        }

        [HttpGet("olay/{userId:int}")]
        public IActionResult GetInviter(int userId)
        {
            //List<Users> result = _usersServices.GetUsers(userId);
            //_usersServices.GetInviterUsername(userId);
            Guid reslt = _usersServices.AddUser(new Users { Name = "Rahman", Family = "Dabouei" });
            return Ok(reslt);
        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("ads")]
        public IActionResult GetAdvertisements()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId);
            return Ok(ads);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("myads")]
        public IActionResult GetMyAdvertisements()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTOAdvertise> ads = _usersServices.GetMyAdvertises(userId);
            return Ok(ads);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("dolike/{advertiseID:guid}")]
        public IActionResult DoLikeAdvertisementByUser(Guid advertiseID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            int result = _usersServices.DoLikeAdvertiseByUserID(advertiseID, userId);
            return Ok(result);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("delPost/{postID:guid}")]
        public IActionResult DeletePost(Guid postID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            bool result = _usersServices.DeleteAdvertise(postID, userId);
            return Ok(result);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("finishDraw/{drawID:guid}")]
        public IActionResult finishDraw(Guid drawID)
        {
            bool result = false;
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            Roles role = _usersServices.GetUserRoles(userId).OrderBy(u => u.Priority).First();
            if (role != null)
            {
                if (role.RoleName == "super" || role.RoleName == "admin")
                {
                    Draws draw = _usersServices.GetAllDraws().Where(d => d.Id == drawID).FirstOrDefault();
                    if (draw != null)
                    {
                        _usersServices.AddPrizeWinner(drawID);
                        draw.IsFinished = true;
                        result = _usersServices.UpdateDraw(draw);
                    }

                }
            }

            return Ok(result);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("deactiveDraw/{drawID:guid}")]
        public IActionResult deactiveDraw(Guid drawID)
        {
            bool result=false;
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            Roles role=_usersServices.GetUserRoles(userId).OrderBy(u => u.Priority).First();
            if (role!=null)
            {
                if (role.RoleName=="super" || role.RoleName=="admin")
                {
                    Draws draw = _usersServices.GetAllDraws().Where(d => d.Id == drawID).FirstOrDefault();
                    if (draw!=null)
                    {
                        _usersServices.AddPrizeWinner(drawID);
                        draw.IsActivated = false;
                        draw.IsFinished = true;
                        result = _usersServices.UpdateDraw(draw);
                    }
                    
                }
            }
            
            return Ok(result);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("getticketusages")]
        public IActionResult GetTicketUsagesByDonnerID()
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid donnerId = Guid.Parse(_userid);
            List<object> result = _usersServices.GetAllUsedPointByDonner(donnerId).OrderByDescending(u => u.Created).ToList<PointUsages>()
                .Join(
                        _usersServices.GetAllUsers(),
                        usages => usages.Receiver,
                        users => users.Id,
                        (usages, users) => new
                            {
                                uname = users.Username,
                                points = usages.Value,
                                date = usages.Created
                            }
                    ).ToList<object>();
            return Ok(result);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("draws")]
        public IActionResult GetDraws()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTODraws> draws = _usersServices.GetAllActiveDrawsByUser(userId);
            return Ok(draws);
        }
        public bool IsValidMobileNumber(string input)
        {
            const string pattern = @"^09[0|1|2|3][0-9]{8}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(input);
        }
        public JsonResult VerifyPhone([FromQuery(Name = "Person.CellPhone")] string Phone)
        {
            if (!IsValidMobileNumber(Phone))
            {
                return new JsonResult($"{Phone} is not valid");
            }

            var phones = _usersServices.GetCellphones();
            if (phones.Contains(Phone))
            {
                return new JsonResult($"{Phone} is already used");
            }
            return new JsonResult(true);
        }

        public JsonResult VerifyUsername([FromQuery(Name = "Person.UserName")] string Username)
        {

            var usernames = _usersServices.GetUsernames();
            if (usernames.Contains(Username))
            {
                return new JsonResult($"{Username} is already used");
            }
            return new JsonResult(true);
        }

    }
}
