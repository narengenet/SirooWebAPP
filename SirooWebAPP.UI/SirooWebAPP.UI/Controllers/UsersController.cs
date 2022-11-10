using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Services;
using SirooWebAPP.Infrastructure.SMS;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.UI.Pages;
using SirooWebAPP.UI.ViewModels;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using IAuthorizationFilter = Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter;

namespace SirooWebAPP.UI.Controllers
{

    public class UsersController : Controller
    {
        private readonly IUserServices _usersServices;
        private readonly ISession _session;

        public UsersController(IUserServices userServices, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = userServices;
            _session = httpContextAccessor.HttpContext.Session;

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
            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId,null);
            return Ok(ads);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("nextads/{lastFetchDate}")]
        public IActionResult GetAdvertismentsAfter(string lastFetchDate)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            DateTime dt = Convert.ToDateTime(lastFetchDate);
            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId,dt);
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
        [HttpGet("pendingads")]
        public IActionResult GetPendingAdvertisements()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTOAdvertise> ads = _usersServices.GetPendingAdvertises(userId);
            return Ok(ads);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("gettransactions")]
        public IActionResult GetTransactions()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<Transactions> transactions = _usersServices.GetTransactionsByUser(userId).OrderByDescending(t => t.Created).ToList<Transactions>();
            foreach (Transactions item in transactions)
            {
                if (item.ReferenceID!=null)
                {
                    item.ReferenceID = item.ReferenceID.Replace("A00000000000000000000000000", "");

                }
            }
            return Ok(transactions);
        }
        
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("getincometransactions")]
        public IActionResult GetIncomeTransactions()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<TransactionPercents> transactions = _usersServices.GetAllTransactionPercents().Where(tp => tp.ToUser == userId).OrderByDescending(t=>t.Created).ToList<TransactionPercents>();
                
            foreach (TransactionPercents item in transactions)
            {
                if (item.ReferenceID!=null)
                {
                    item.ReferenceID = item.ReferenceID.Replace("A00000000000000000000000000", "");

                }
            }
            return Ok(transactions);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("viewedPost/{advertiseID:guid}")]
        public IActionResult WatchedAdvertisementByUser(Guid advertiseID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            DTOAdvertise result = _usersServices.WatchedAdvertiseByUserID(advertiseID, userId);
            return Ok(result);
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
        [HttpGet("delqr/{qrID:guid}")]
        public IActionResult DelQR(Guid qrID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            bool result = _usersServices.removeDonnationTicket(qrID, userId);
            return Ok(result);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("delPost/{postID:guid}")]
        public IActionResult DeletePost(Guid postID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            bool result = _usersServices.DeleteAdvertise(postID, userId);
            Advertise tmp= CachedContents.Advertises.Where(u => u.Id == postID).FirstOrDefault();
            CachedContents.Advertises.Remove(tmp);
            return Ok(result);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("finishDraw/{drawID:guid}")]
        public IActionResult finishDraw(Guid drawID)
        {
            bool result = false;
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            Roles role = _usersServices.GetUserRoles(userId).OrderBy(u => u.Priority).FirstOrDefault();
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
            bool result = false;
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            Roles role = _usersServices.GetUserRoles(userId).OrderBy(u => u.Priority).FirstOrDefault();
            if (role != null)
            {
                if (role.RoleName == "super" || role.RoleName == "admin")
                {
                    Draws draw = _usersServices.GetAllDraws().Where(d => d.Id == drawID).FirstOrDefault();
                    if (draw != null)
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

        public class Post
        {
            public string adId { get; set; }
            public string adNote { get; set; }
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpPost("acceptPost")]
        public IActionResult AcceptAds([FromBody] Post post)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Guid adId = Guid.Parse(post.adId);
                Advertise ad = _usersServices.GetAdvertise(adId);
                if (ad != null)
                {
                    ad.IsAvtivated = true;
                    ad.LastModified = DateTime.Now;
                    ad.LastModifiedBy = userId.ToString();
                    ad.Notes = post.adNote;
                    _usersServices.UpdateAdvertisement(ad);
                    CachedContents.Advertises.Insert(0, ad);
                    return Ok(true);
                }
            }
            //List<DTODraws> draws = _usersServices.GetAllActiveDrawsByUser(userId);
            return Ok(false);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpPost("rejectPost")]
        public IActionResult RejectAds([FromBody] Post post)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Guid adId = Guid.Parse(post.adId);
                Advertise ad = _usersServices.GetAdvertise(adId);
                if (ad != null)
                {
                    ad.IsAvtivated = true;
                    ad.LastModified = DateTime.Now;
                    ad.LastModifiedBy = userId.ToString();
                    ad.Notes = post.adNote;
                    ad.IsRejected = true;
                    _usersServices.UpdateAdvertisement(ad);
                    return Ok(true);
                }
            }

            return Ok(false);
        }
        public bool IsValidMobileNumber(string input)
        {
            const string pattern = @"^09[0-9][0-9]{8}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(input);
        }
        public JsonResult VerifyPhone([FromQuery(Name = "Person.CellPhone")] string Phone)
        {
            if (!IsValidMobileNumber(Phone))
            {
                return new JsonResult($"{Phone} معتبر نیست");
            }

            var phones = _usersServices.GetCellphones();
            if (phones.Contains(Phone))
            {
                return new JsonResult($"{Phone} قبلا ثبت شده است.");
            }
            return new JsonResult(true);
        }

        public JsonResult VerifyUsername([FromQuery(Name = "Person.UserName")] string Username)
        {
            string theusername = HelperFunctions.SanitizeQuery(Username);
            List<string> searchedResult= _usersServices.GetUsernames().Where(s => s == theusername).ToList<string>();
            if (searchedResult.Count>0)
            {
                return new JsonResult($"{Username} "+"قبلا ثبت شده است.");
            }
            //var usernames = _usersServices.GetUsernames();
            //if (usernames.Contains(Username))
            //{
            //    return new JsonResult($"{Username} is already used");
            //}
            return new JsonResult(true);
        }



















        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("sendsms")]
        public IActionResult SensSms()
        {
            //string resp= SMSSender.SendToPattern();

            return Ok("ok");
        }




















        //string merchant = "218dd966-3888-4324-921d-84bb0726f3b5";
        string merchant = "218dd966-3888-4324-921d-84bb0726f3b5";
        string amount = "1100";
        string authority;
        string description = "خرید تستی ";
        
#if DEBUG        
        string callbackurl = "https://localhost:7051/VerifyByHttpClient";
#else
        string callbackurl = "https://sirooapp.ir/VerifyByHttpClient";
#endif






        [HttpGet("Payment")]
        public IActionResult Payment(string theAmount, string theDescription)
        {
#if DEBUG
            theAmount = "10000";
#endif
            amount = theAmount;
            
            description = theDescription;
            try
            {
                RequestParameters Parameters = new RequestParameters(merchant, theAmount, theDescription, callbackurl, "", "");



                //be dalil in ke metadata be sorate araye ast va do meghdare mobile va email dar metadata gharar mmigirad
                //shoma mitavanid in maghadir ra az kharidar begirid va set konid dar gheir in sorat khali ersal konid

                var client = new RestClient(URLs.requestUrl);

                Method method = Method.POST;

                var request = new RestRequest("", method);

                request.AddHeader("accept", "application/json");

                request.AddHeader("content-type", "application/json");

                request.AddJsonBody(Parameters);

                var requestresponse = client.ExecuteAsync(request);

                JObject jo = JObject.Parse(requestresponse.Result.Content);

                string errorscode = jo["errors"].ToString();

                JObject jodata = JObject.Parse(requestresponse.Result.Content);

                string dataauth = jodata["data"].ToString();


                if (dataauth != "[]")
                {


                    authority = jodata["data"]["authority"].ToString();

                    string gatewayUrl = URLs.gateWayUrl + authority;
                    Guid _transcId = Guid.Parse(theDescription);
                    Transactions transac = _usersServices.GetAllTransactions().Where(t => t.Id == _transcId).FirstOrDefault();
                    transac.ReferenceID = authority;
                    _usersServices.UpdateTransaction(transac);
                    _session.SetString(authority, theAmount);
                    return Redirect(gatewayUrl);

                }
                else
                {


                    return BadRequest("error " + errorscode);


                }


            }

            catch (Exception ex)
            {
                //    throw new Exception(ex.Message);


            }
            return null;
        }
        [HttpGet("VerifyPayment")]
        public IActionResult VerifyPayment()
        {

            // string authorityverify;

            try
            {
                VerifyParameters parameters = new VerifyParameters();


                if (HttpContext.Request.Query["Authority"] != "")
                {
                    authority = HttpContext.Request.Query["Authority"];
                }

                parameters.authority = authority;
                parameters.amount = _session.GetString(authority);
                parameters.merchant_id = merchant;


                var client = new RestClient(URLs.verifyUrl);
                Method method = Method.POST;
                var request = new RestRequest("", method);

                request.AddHeader("accept", "application/json");

                request.AddHeader("content-type", "application/json");
                request.AddJsonBody(parameters);

                var response = client.ExecuteAsync(request);


                JObject jodata = JObject.Parse(response.Result.Content);

                string data = jodata["data"].ToString();

                JObject jo = JObject.Parse(response.Result.Content);

                string errors = jo["errors"].ToString();

                if (data != "[]")
                {
                    string refid = jodata["data"]["ref_id"].ToString();

                    ViewBag.code = refid;

                    return View();
                }
                else if (errors != "[]")
                {

                    string errorscode = jo["errors"]["code"].ToString();


                    return BadRequest($"error code {errorscode}");

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return NotFound();
        }
        [HttpGet("PaymenBytHttpClient")]
        public async Task<IActionResult> PaymenBytHttpClient()
        {

            try
            {

                using (var client = new HttpClient())
                {
                    RequestParameters parameters = new RequestParameters(merchant, amount, description, callbackurl, "", "");

                    var json = JsonConvert.SerializeObject(parameters);

                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(URLs.requestUrl, content);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject jo = JObject.Parse(responseBody);
                    string errorscode = jo["errors"].ToString();

                    JObject jodata = JObject.Parse(responseBody);
                    string dataauth = jodata["data"].ToString();


                    
                    if (dataauth != "[]")
                    {
                        

                        authority = jodata["data"]["authority"].ToString();

                        string gatewayUrl = URLs.gateWayUrl + authority;

                        return Redirect(gatewayUrl);

                    }
                    else
                    {

                        return BadRequest("error " + errorscode);


                    }

                }


            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);


            }
            return NotFound();
        }
        [HttpGet("VerifyByHttpClient")]
        public async Task<IActionResult> VerifyByHttpClient()
        {
            try
            {

                VerifyParameters parameters = new VerifyParameters();


                if (HttpContext.Request.Query["Authority"] != "")
                {
                    authority = HttpContext.Request.Query["Authority"];
                }

                parameters.authority = authority;

                parameters.amount = _session.GetString(authority);

                parameters.merchant_id = merchant;


                using (HttpClient client = new HttpClient())
                {

                    var json = JsonConvert.SerializeObject(parameters);

                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(URLs.verifyUrl, content);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject jodata = JObject.Parse(responseBody);

                    string data = jodata["data"].ToString();

                    JObject jo = JObject.Parse(responseBody);

                    string errors = jo["errors"].ToString();

                    Transactions transac = _usersServices.GetAllTransactions().Where(t => t.ReferenceID == authority).FirstOrDefault();

                    if (data != "[]")
                    {
                        string refid = jodata["data"]["ref_id"].ToString();

                        ViewBag.code = refid;
                        transac.Status = "موفقیت آمیز";
                        transac.IsSuccessfull = true;

                        // update transaction in db
                        _usersServices.UpdateTransaction(transac);

                        // get user and add money to his/her current money deposite
                        Users theUser = _usersServices.GetUser(transac.User);
                        theUser.Money += transac.Amount;
                        _usersServices.UpdateUser(theUser);


                        _session.Remove(authority);
                        return RedirectToPage("/Clients/PaymentResult","Display", new {TransactionId=transac.Id ,  RefId= authority, Status=true, Code="success" });
                        

                        //return View();
                    }
                    else if (errors != "[]")
                    {

                        string errorscode = jo["errors"]["code"].ToString();
                        transac.Status= jo["errors"]["code"].ToString();
                        transac.IsSuccessfull = false;
                        _usersServices.UpdateTransaction(transac);
                        _session.Remove(authority);
                        return RedirectToPage("/Clients/PaymentResult", "Display", new { RefId = authority, Status = false, Code = transac.Status });
                        //return BadRequest($"error code {errorscode}");

                    }
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }
            return NotFound();
        }



















    }
}
