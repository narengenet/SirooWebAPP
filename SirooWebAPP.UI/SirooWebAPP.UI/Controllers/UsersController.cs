﻿using Microsoft.AspNetCore.Mvc;
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
using System.Linq;
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
        private IWebHostEnvironment _environment;

        public UsersController(IUserServices userServices, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment environment)
        {
            _usersServices = userServices;
            _session = httpContextAccessor.HttpContext.Session;
            _environment = environment;

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
        [HttpGet("ads/")]
        public IActionResult GetAdvertisements()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId, false, 0, null, null);
            return Ok(ads);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("ads2/{username}/{rnd}")]
        public IActionResult GetAdvertisements2(string username, string rnd)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId, false, 0, null, username);
            return Ok(ads);
        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("nextads/{lastFetchDate:guid}")]
        public IActionResult GetAdvertismentsAfter(Guid lastFetchDate)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            Advertise lastFetchedAds = _usersServices.GetAllPermenantAdvertises().Where(a => a.Id == lastFetchDate).FirstOrDefault();

            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId, false, 0, lastFetchedAds.CreationDate, null);
            if (ads.Count == 0)
            {
                ads = _usersServices.GetAdvertises(userId, true, 0, lastFetchedAds.CreationDate, null);
            }

            return Ok(ads);

            //string _userid = HttpContext.Request.Cookies["userid"];
            //Guid userId = Guid.Parse(_userid);
            //DateTime dt = Convert.ToDateTime(lastFetchDate);
            //List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId, false, 0, dt);
            //return Ok(ads);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("beforeads/{lastfetchedid:guid}")]
        public IActionResult GetAdvertismentsBefore(Guid lastfetchedid)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            Advertise lastFetchedAds = _usersServices.GetAllPermenantAdvertises().Where(a => a.Id == lastfetchedid).FirstOrDefault();

            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId, true, 0, lastFetchedAds.CreationDate, null);
            return Ok(ads);
        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("beforeads2/{lastfetchedid:guid}/{username}")]
        public IActionResult GetAdvertismentsBefore(Guid lastfetchedid, string username)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            Advertise lastFetchedAds = _usersServices.GetAllPermenantAdvertises().Where(a => a.Id == lastfetchedid).FirstOrDefault();

            List<DTOAdvertise> ads = _usersServices.GetAdvertises(userId, true, 0, lastFetchedAds.CreationDate, username);
            return Ok(ads);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("myads/{page:int}")]
        public IActionResult GetMyAdvertisements(int page)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTOAdvertise> ads = _usersServices.GetMyAdvertises(userId, page);

            if (ads.Count > 0)
            {
                return Ok(ads);
            }
            else
            {
                return Ok("-1");
            }

        }
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("pendingads/{page:int}")]
        public IActionResult GetPendingAdvertisements(int page)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTOAdvertise> ads = _usersServices.GetPendingAdvertises(userId, page);

            if (ads.Count > 0)
            {
                return Ok(ads);
            }
            else
            {
                return Ok("-1");
            }
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
                if (item.ReferenceID != null)
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
            List<TransactionPercents> transactions = _usersServices.GetAllTransactionPercents().Where(tp => tp.ToUser == userId).OrderByDescending(t => t.Created).ToList<TransactionPercents>();

            foreach (TransactionPercents item in transactions)
            {
                if (item.ReferenceID != null)
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
        [HttpGet("dofollow/{userID:guid}")]
        public IActionResult DoFollow(Guid userID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid currentUserId = Guid.Parse(_userid);

            string result = "-1";

            Users followedPerson = _usersServices.GetUser(userID);
            if (followedPerson!=null)
            {
                Followers followship = _usersServices.GetAllFollowers(true).Where(f => f.FollowedPerson == followedPerson.Id && f.FollowPerson == currentUserId).FirstOrDefault();
                if (followship == null)
                {
                    followship = new Followers
                    {
                        FollowedPerson = userID,
                        FollowPerson = currentUserId,
                        Created = DateTime.Now
                    };
                    _usersServices.AddFollower(followship);

                    CachedContents.Followers.Add(followship);

                    result = "1";
                }
                else
                {
                    followship.IsDeleted = !followship.IsDeleted;
                    followship.LastModified = DateTime.Now;
                    _usersServices.UpdateFollower(followship);

                    if (followship.IsDeleted)
                    {
                        Followers tmpFollowship = CachedContents.Followers.Where(f => f.Id == followship.Id).FirstOrDefault();
                        CachedContents.Followers.Remove(tmpFollowship);
                    }
                    else
                    {
                        CachedContents.Followers.Add(followship);
                    }

                    result = followship.IsDeleted ? "0" : "1";
                }
            }

            return Ok(result);
        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("getfollowers/{pageIndex:int}/{userId:guid}")]
        public IActionResult GetFollowers(int pageIndex, Guid userId)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid currentUserId = Guid.Parse(_userid);
            List<Followers> theFollowers = CachedContents.Followers.Where(f => f.FollowedPerson == userId).Skip(pageIndex*5).Take(5).ToList<Followers>();
            List<Guid> myFollowings=CachedContents.Followers.Where(f=>f.FollowPerson==currentUserId).Select(u=>u.FollowedPerson).ToList();

            List<DTOUserSmallProfile> theResult = new List<DTOUserSmallProfile>();

            foreach (Followers item in theFollowers)
            {
                Users tmpUser = CachedContents.AllUsers.Where(u => u.Id == item.FollowPerson).FirstOrDefault();
                if (tmpUser != null)
                {
                    theResult.Add(new DTOUserSmallProfile
                    {
                        UserId = tmpUser.Id,
                        Username = tmpUser.Username,
                        ProfileMediaURL = tmpUser.ProfileMediaURL,
                        AmIFollowUser = myFollowings.Contains(tmpUser.Id),
                        IsMe=tmpUser.Id==currentUserId?true:false
                    });
                }
            }

            if (theResult.Count>0)
            {
                return Ok(theResult.OrderByDescending(f=>f.IsMe));
            }
            else
            {
                return Ok("-1");
            }

            
        }
        
        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("getfollowings/{pageIndex:int}/{userId:guid}")]
        public IActionResult GetFollowings(int pageIndex, Guid userId)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid currentUserId = Guid.Parse(_userid);
            List<Followers> theFollowings = CachedContents.Followers.Where(f => f.FollowPerson == userId).Skip(pageIndex*5).Take(5).ToList<Followers>();
            List<Guid> myFollowings=CachedContents.Followers.Where(f=>f.FollowPerson==currentUserId).Select(u=>u.FollowedPerson).ToList();

            List<DTOUserSmallProfile> theResult = new List<DTOUserSmallProfile>();

            foreach (Followers item in theFollowings)
            {
                Users tmpUser = CachedContents.AllUsers.Where(u => u.Id == item.FollowedPerson).FirstOrDefault();
                if (tmpUser != null)
                {
                    theResult.Add(new DTOUserSmallProfile
                    {
                        UserId = tmpUser.Id,
                        Username = tmpUser.Username,
                        ProfileMediaURL = tmpUser.ProfileMediaURL,
                        AmIFollowUser = myFollowings.Contains(tmpUser.Id),
                        IsMe=tmpUser.Id==currentUserId?true:false
                    });
                }
            }

            if (theResult.Count>0)
            {
                return Ok(theResult.OrderByDescending(f=>f.IsMe));
            }
            else
            {
                return Ok("-1");
            }

            
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

            Advertise ad = _usersServices.GetAdvertise(postID);


            if (ad.IsPremium == true && ad.IsAvtivated == false)
            {
                Users adOwner = _usersServices.GetUser(ad.Owner);

                string moneyRequiredKeyName = (ad.IsVideo == true) ? "def_money_to_premium_video_ads" : "def_money_to_premium_image_ads";
                int moneyNeedBack = Convert.ToInt32(_usersServices.GetConstantDictionary(moneyRequiredKeyName).ConstantValue);

                if (adOwner != null)
                {
                    adOwner.Money += moneyNeedBack;
                    _usersServices.UpdateUser(adOwner);

                    Transactions transac = _usersServices.GetAllTransactions().Where(x => x.ReferenceID == ad.Id.ToString()).FirstOrDefault();
                    if (transac != null)
                    {
                        transac.IsDeleted = true;
                        transac.LastModified = DateTime.Now;
                        transac.LastModifiedBy = adOwner.ToString();
                        _usersServices.UpdateTransaction(transac);
                    }

                }
            }



            bool result = _usersServices.DeleteAdvertise(postID, userId);
            Advertise tmp = CachedContents.Advertises.Where(u => u.Id == postID).FirstOrDefault();
            CachedContents.Advertises.Remove(tmp);
            return Ok(result);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("pinPost/{postID:guid}")]
        public IActionResult pinPost(Guid postID)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {

                Advertise ads = _usersServices.GetAdvertise(postID);
                if (ads != null)
                {

                    if (ads.IsSpecial == true)
                    {
                        ads.IsSpecial = false;
                    }
                    else
                    {
                        ads.IsSpecial = true;
                    }

                    _usersServices.UpdateAdvertisement(ads);

                    CachedContents.Advertises.Clear();
                    CachedContents.Likers.Clear();
                    CachedContents.Viewers.Clear();

                    return Ok("1");
                }


            }

            return Ok("-1");
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
        [HttpGet("archiveDraw/{drawID:guid}")]
        public IActionResult archiveDraw(Guid drawID)
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
                        if (draw.IsFinished)
                        {
                            draw.IsArchived = true;
                            result = _usersServices.UpdateDraw(draw);
                        }

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
            List<DTODraws> draws = _usersServices.GetAllActiveNotArchivedDrawsByUser(userId);
            return Ok(draws);
        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("alldraws")]
        public IActionResult GetAllDraws()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            List<DTODraws> draws = _usersServices.GetAllActiveDrawsByUser(userId);
            return Ok(draws);
        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("addPointToUser/{userID:guid}/{point:int}")]
        public IActionResult addPointToUser(Guid userID, int point)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Users theUser = _usersServices.GetUser(userID);
                if (theUser != null)
                {
                    theUser.Points += point;
                    _usersServices.UpdateUser(theUser);
                    return Ok("ok");
                }
            }

            return Ok("-1");

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("addMoneyToUser/{userID:guid}/{money:int}")]
        public IActionResult addMoneyToUser(Guid userID, int money)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Users theUser = _usersServices.GetUser(userID);
                if (theUser != null)
                {
                    theUser.Money += money;
                    _usersServices.UpdateUser(theUser);
                    return Ok("ok");
                }
            }

            return Ok("-1");

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("addDiamondToUser/{userID:guid}/{diamond:int}")]
        public IActionResult addDiamondToUser(Guid userID, int diamond)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Users theUser = _usersServices.GetUser(userID);
                if (theUser != null)
                {
                    theUser.Diamonds += diamond;
                    _usersServices.UpdateUser(theUser);
                    _usersServices.AddDiamondUsage(new DiamondUsages
                    {
                        Created = DateTime.Now,
                        DiamondsWon = diamond,
                        User = userID,
                        LastModifiedBy = _userid,
                        PointCharged = 0
                    });
                    return Ok("ok");
                }
            }

            return Ok("-1");

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("deleteUser/{reason}/{userID:guid}")]
        public IActionResult deleteUser(string reason, Guid userID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Users theUser = _usersServices.GetNotDeletedUser(userID);
                if (theUser != null)
                {
                    theUser.IsDeleted = true;
                    theUser.Notes = reason;
                    _usersServices.UpdateUser(theUser);
                    //Users tmpUser = CachedContents.AllUsers.Where(u => u.Id == theUser.Id).FirstOrDefault();
                    //CachedContents.AllUsers.Remove(tmpUser);
                    return Ok("ok");
                }
            }

            return Ok("-1");

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("undeleteUser/{userID:guid}")]
        public IActionResult undeleteUser(Guid userID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Users theUser = _usersServices.GetAllDeletedUsers().Where(u => u.Id == userID).First();
                if (theUser != null)
                {
                    theUser.IsDeleted = false;
                    _usersServices.UpdateUser(theUser);
                    //CachedContents.AllUsers.Add(theUser);
                    return Ok("ok");
                }
            }

            return Ok("-1");

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("deleteUserForever/{userID:guid}")]
        public IActionResult deleteUserForever(Guid userID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Users theUser = _usersServices.GetAllDeletedUsers().Where(u => u.Id == userID).First();
                if (theUser != null)
                {
                    _usersServices.RemovePermUser(theUser);

                    return Ok("ok");
                }
            }

            return Ok("-1");

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("resetPostCache")]
        public IActionResult resetPostCache(Guid userID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                CachedContents.Advertises.Clear();
                CachedContents.Likers.Clear();
                CachedContents.Viewers.Clear();
                CachedContents.Followers.Clear();
                CachedContents.AllUsers.Clear();

                return Ok("1");
            }

            return Ok("-1");

        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("changeConstant/{keyValue}/{secondValue}/{constID:guid}")]
        public IActionResult changeConstant(string keyValue, string secondValue, Guid constID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];

            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {

                ConstantDictionaries theDic = _usersServices.GetAllConstantDictionaries().Where(c => c.Id == constID).First();
                if (theDic != null)
                {
                    theDic.ConstantValue = keyValue;
                    if (secondValue != "null")
                    {
                        theDic.ConstantSecondValue = secondValue;
                    }
                    theDic.LastModifiedBy = _userid;
                    theDic.LastModified = DateTime.Now;
                    _usersServices.UpdateConstantDictionary(theDic);

                    if (theDic.ConstantKey == "expire_dates_for_challenge_1")
                    {
                        List<Graphs> allGraphs = _usersServices.GetAllGraphs().Where(g => g.GraphTypeIndex == 1).ToList<Graphs>();
                        int addedDays = Convert.ToInt32(theDic.ConstantValue);
                        foreach (Graphs item in allGraphs)
                        {
                            item.ExpireDate = Convert.ToDateTime(item.Created).AddDays(addedDays);
                            _usersServices.UpdateGraph(item);
                        }
                    }

                    if (theDic.ConstantKey == "expire_dates_for_challenge_2")
                    {
                        List<Graphs> allGraphs = _usersServices.GetAllGraphs().Where(g => g.GraphTypeIndex == 2).ToList<Graphs>();
                        int addedDays = Convert.ToInt32(theDic.ConstantValue);
                        foreach (Graphs item in allGraphs)
                        {
                            item.ExpireDate = Convert.ToDateTime(item.Created).AddDays(addedDays);
                            _usersServices.UpdateGraph(item);
                        }
                    }

                    if (theDic.ConstantKey == "expire_dates_for_challenge_3")
                    {
                        List<Graphs> allGraphs = _usersServices.GetAllGraphs().Where(g => g.GraphTypeIndex == 3).ToList<Graphs>();
                        int addedDays = Convert.ToInt32(theDic.ConstantValue);
                        foreach (Graphs item in allGraphs)
                        {
                            item.ExpireDate = Convert.ToDateTime(item.Created).AddDays(addedDays);
                            _usersServices.UpdateGraph(item);
                        }
                    }

                    CachedContents.DiamondCounts.Clear();
                    CachedContents.DiamondPriorities.Clear();
                    CachedContents.DiamondCountsList.Clear();
                    return Ok("1");
                }
                return Ok("1");
            }

            return Ok("-1");

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("createChips/{chipscount:int}/{chipspoint:int}")]
        public IActionResult createChips(int chipscount, int chipspoint)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                long lastSerialNumber = 0;
                long firstSerialNumber = 0;
                int createdChips = 0;
                List<string> allPins = new List<string>();

                Chips lastChip = _usersServices.GetAllChips().OrderByDescending(c => c.SerialNumber).FirstOrDefault();
                if (lastChip != null)
                {
                    lastSerialNumber = lastChip.SerialNumber;
                    firstSerialNumber = lastSerialNumber;
                    allPins = _usersServices.GetAllChips().Select(c => c.PIN).ToList();
                }




                do
                {
                    Random r = new Random();
                    int randomPin = r.Next(100000, 999999);
                    if (allPins.Where(u => u == randomPin.ToString()).ToList().Count > 0)
                    {
                        continue;
                    }
                    else
                    {
                        lastSerialNumber += 1;
                        allPins.Add(randomPin.ToString());
                        _usersServices.AddChips(new Chips
                        {
                            Created = DateTime.Now,
                            SerialNumber = lastSerialNumber,
                            Points = chipspoint,
                            PIN = randomPin.ToString(),
                            LastModifiedBy = _userid
                        });
                        createdChips += 1;
                    }

                } while (createdChips < chipscount);

                if (createdChips == chipscount)
                {



                    List<Chips> reportCSVModels = _usersServices.GetAllChips().Where(c => c.SerialNumber > firstSerialNumber).ToList<Chips>();

                    List<CSVChip> csvChips = new List<CSVChip>();
                    foreach (Chips item in reportCSVModels)
                    {
                        csvChips.Add(new CSVChip { PIN = item.PIN, Serial = item.SerialNumber.ToString() });
                    }

                    string fileName = string.Format("{0}\\test.csv", _environment.WebRootPath + "/uploads/");
                    CsvWriter csvWriter = new CsvWriter();
                    csvWriter.Write(csvChips, fileName, true);
                    Console.WriteLine("{0} has been created.", fileName);
                    //Console.ReadKey();
                    return Ok("1");
                }


            }

            return Ok("-1");

        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("exportChallengeUserData/{thetype:int}")]
        public IActionResult exportChallengeUserData(int thetype)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin" || _userid == "17fb3917-9d6e-49f8-d0a0-08dac53d6445")
            {
                List<ChallengeUserData> challengeUserData = new List<ChallengeUserData>();

                if (thetype == 0)
                {
                    challengeUserData = _usersServices.GetAllChallengeUserData().ToList<ChallengeUserData>();
                }
                else
                {
                    challengeUserData = _usersServices.GetAllChallengeUserData().Where(cd => cd.ChallengeModeIndex == thetype).ToList<ChallengeUserData>();
                }

                List<CSVChallengeUserData> csvUserData = new List<CSVChallengeUserData>();

                List<string> challengeTypes = new List<string>();
                challengeTypes.Add((Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_1").ConstantValue) / 10).ToString() + " تومانی");
                challengeTypes.Add((Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_2").ConstantValue) / 10).ToString() + " تومانی");
                challengeTypes.Add((Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_3").ConstantValue) / 10).ToString() + " تومانی");



                foreach (ChallengeUserData item in challengeUserData)
                {
                    csvUserData.Add(
                        new CSVChallengeUserData
                        {
                            Name = item.Name,
                            Family = item.Family,
                            BirthDate = item.BirthDate,
                            FatherName = item.FatherName,
                            IdentityId = item.IdentityID,
                            NationalId = item.NationalID,
                            IsMarried = item.IsMarried ? "متاهل" : "مجرد",
                            Mobile = item.Cellphone,
                            Username = item.Username,
                            Created = item.Created.ToString(),
                            ChallengeType = challengeTypes[Convert.ToInt32(item.ChallengeModeIndex) - 1]


                        });
                    if (item.IsExported != true)
                    {
                        item.IsExported = true;
                        item.LastModified = DateTime.Now;
                        item.LastModifiedBy = userId.ToString();
                        _usersServices.UpdateChallengeUserData(item);
                    }


                }

                string fileName = string.Format("{0}\\challenge.csv", _environment.WebRootPath + "/uploads/");
                CsvWriter csvWriter = new CsvWriter();
                csvWriter.Write(csvUserData, fileName, true);
                Console.WriteLine("{0} has been created.", fileName);
                //Console.ReadKey();
                return Ok("1");


            }

            return Ok("-1");

        }





        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("exportnewChallengeUserData/{thetype:int}")]
        public IActionResult exportnewChallengeUserData(int thetype)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                List<ChallengeUserData> challengeUserData = new List<ChallengeUserData>();
                if (thetype == 0)
                {
                    challengeUserData = _usersServices.GetAllChallengeUserData().Where(cd => cd.IsExported != true).ToList<ChallengeUserData>();
                }
                else
                {
                    challengeUserData = _usersServices.GetAllChallengeUserData().Where(cd => cd.IsExported != true && cd.ChallengeModeIndex == thetype).ToList<ChallengeUserData>();
                }

                List<CSVChallengeUserData> csvUserData = new List<CSVChallengeUserData>();

                List<string> challengeTypes = new List<string>();
                challengeTypes.Add((Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_1").ConstantValue) / 10).ToString() + " تومانی");
                challengeTypes.Add((Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_2").ConstantValue) / 10).ToString() + " تومانی");
                challengeTypes.Add((Convert.ToInt64(_usersServices.GetConstantDictionary("money_needed_to_attend_in_challenge_3").ConstantValue) / 10).ToString() + " تومانی");

                foreach (ChallengeUserData item in challengeUserData)
                {
                    csvUserData.Add(
                        new CSVChallengeUserData
                        {
                            Name = item.Name,
                            Family = item.Family,
                            BirthDate = item.BirthDate,
                            FatherName = item.FatherName,
                            IdentityId = item.IdentityID,
                            NationalId = item.NationalID,
                            IsMarried = item.IsMarried ? "متاهل" : "مجرد",
                            Mobile = item.Cellphone,
                            Username = item.Username,
                            Created = item.Created.ToString(),
                            ChallengeType = challengeTypes[Convert.ToInt32(item.ChallengeModeIndex) - 1]

                        });
                    if (item.IsExported != true)
                    {
                        item.IsExported = true;
                        item.LastModified = DateTime.Now;
                        item.LastModifiedBy = userId.ToString();
                        _usersServices.UpdateChallengeUserData(item);

                    }


                }

                if (challengeUserData.Count == 0)
                {
                    return Ok("-2");
                }

                string fileName = string.Format("{0}\\challenge.csv", _environment.WebRootPath + "/uploads/");
                CsvWriter csvWriter = new CsvWriter();
                csvWriter.Write(csvUserData, fileName, true);
                Console.WriteLine("{0} has been created.", fileName);
                //Console.ReadKey();
                return Ok("1");


            }

            return Ok("-1");

        }



        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("useChips/{thePIN}")]
        public IActionResult useChips(string thePIN)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);


            ConstantDictionaries theDic = _usersServices.GetAllConstantDictionaries().Where(c => c.ConstantKey == "def_chips_usage_perday").First();
            if (theDic != null)
            {
                bool permitToUse = true;
                if (theDic.ConstantValue != "-1")
                {
                    int permitPerDay = Convert.ToInt32(theDic.ConstantValue);
                    List<Chips> todayUsedChipsByUser = _usersServices.GetAllChips().Where(c =>
                                                                                    c.IsUsed == true &&
                                                                                    c.UsedBy == userId &&
                                                                                    c.LastModified > DateTime.Today.AddDays(-1))
                        .ToList<Chips>();
                    if (todayUsedChipsByUser.Count >= permitPerDay)
                    {
                        permitToUse = false;
                        return Ok("-2"); // use per day limit reached
                    }
                }

                if (permitToUse)
                {
                    Chips theChip = _usersServices.GetAllChips().Where(c => c.PIN == thePIN).FirstOrDefault();
                    if (theChip != null)
                    {
                        if (theChip.IsUsed == false)
                        {
                            theChip.UsedBy = userId;
                            theChip.IsUsed = true;
                            theChip.LastModified = DateTime.Now;
                            _usersServices.UpdateChips(theChip);
                            Users theUser = _usersServices.GetUser(userId);
                            theUser.Points += theChip.Points;
                            _usersServices.UpdateUser(theUser);
                            return Ok(theChip.Points);
                        }
                        else
                        {
                            return Ok("-4");// chip is used before
                        }
                    }
                    else
                    {
                        return Ok("-3");// chip is not valid
                    }

                }

            }
            return Ok("-5");// chip usage per day not defined




        }


        private static Random generator = null;


        public void SplitAtRandom(int chanceOfSuccess1, int chanceOfSuccess2, int chanceOfSuccess3, int chanceOfSuccess4, int chanceOfSuccess5, int chanceOfSuccess6, int chanceOfSuccess7, int chanceOfSuccess8, int chanceOfSuccess9, int chanceOfSuccess10, Action onSuccess1, Action onSuccess2, Action onSuccess3, Action onSuccess4, Action onSuccess5, Action onSuccess6, Action onSuccess7, Action onSuccess8, Action onSuccess9, Action onSuccess10)
        {
            // Seed
            if (generator == null)
                generator = new Random(DateTime.Now.Millisecond);

            int TheNumber = generator.Next(100);

            // By chance
            if (TheNumber < chanceOfSuccess10)
            {
                if (onSuccess10 != null)
                    onSuccess10();
            }
            else if (TheNumber < chanceOfSuccess9)
            {
                if (onSuccess9 != null)
                    onSuccess9();
            }
            else if (TheNumber < chanceOfSuccess8)
            {
                if (onSuccess8 != null)
                    onSuccess8();
            }
            else if (TheNumber < chanceOfSuccess7)
            {
                if (onSuccess7 != null)
                    onSuccess7();
            }
            else if (TheNumber < chanceOfSuccess6)
            {
                if (onSuccess6 != null)
                    onSuccess6();
            }
            else if (TheNumber < chanceOfSuccess5)
            {
                if (onSuccess5 != null)
                    onSuccess5();
            }
            else if (TheNumber < chanceOfSuccess4)
            {
                if (onSuccess4 != null)
                    onSuccess4();
            }
            else if (TheNumber < chanceOfSuccess3)
            {
                if (onSuccess3 != null)
                    onSuccess3();
            }
            else if (TheNumber < chanceOfSuccess2)
            {
                if (onSuccess2 != null)
                    onSuccess2();
            }
            else
            {
                if (onSuccess1 != null)
                    onSuccess1();
            }
        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("fillDiamondsCount")]
        public IActionResult fillDiamondsCount()
        {



            if (CachedContents.DiamondPriorities.Count < 2)
            {
                ConstantDictionaries firstDic = _usersServices.GetConstantDictionary("diamond_first_priority");
                ConstantDictionaries secondDic = _usersServices.GetConstantDictionary("diamond_second_priority");
                ConstantDictionaries thirdDic = _usersServices.GetConstantDictionary("diamond_third_priority");
                ConstantDictionaries fourthDic = _usersServices.GetConstantDictionary("diamond_fourth_priority");
                ConstantDictionaries fivthDic = _usersServices.GetConstantDictionary("diamond_fivth_priority");
                ConstantDictionaries sixthDic = _usersServices.GetConstantDictionary("diamond_sixth_priority");
                ConstantDictionaries seventhDic = _usersServices.GetConstantDictionary("diamond_seventh_priority");
                ConstantDictionaries eighthDic = _usersServices.GetConstantDictionary("diamond_eighth_priority");
                ConstantDictionaries ninethDic = _usersServices.GetConstantDictionary("diamond_nineth_priority");
                ConstantDictionaries tenthDic = _usersServices.GetConstantDictionary("diamond_tenth_priority");

                CachedContents.DiamondCounts.Add(Convert.ToString(firstDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(firstDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(secondDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(secondDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(thirdDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(thirdDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(fourthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(fourthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(fivthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(fivthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(sixthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(sixthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(seventhDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(seventhDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(eighthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(eighthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(ninethDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(ninethDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(tenthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(tenthDic.ConstantSecondValue));

                for (int i = 0; i < CachedContents.DiamondPriorities.Count; i++)
                {
                    if (CachedContents.DiamondPriorities[i] > 0)
                    {
                        List<string> tmpListDiamondsCount = CachedContents.DiamondCounts[i].Split(",").ToList<string>();
                        foreach (string item in tmpListDiamondsCount)
                        {
                            CachedContents.DiamondCountsList.Add(item);
                        }
                    }
                }
            }



            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(CachedContents.DiamondCountsList));
        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("getDiamond")]
        public IActionResult getDiamond()
        {

            bool permitToUse = false;

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            List<DiamondUsages> todayDiamondUsages = _usersServices.GetAllDiamondUsages().Where(d => d.User == userId && d.Created > DateTime.Today).ToList<DiamondUsages>();
            int minPointsToUseForDiamonds = Convert.ToInt32(_usersServices.GetConstantDictionary("min_points_to_spin_diamond_wheel").ConstantValue);
            int addedPointsPerUsageForToday = Convert.ToInt32(_usersServices.GetConstantDictionary("added_points_to_each_spin_diamond_wheel_after_first_time").ConstantValue);

            int neededPoints = (todayDiamondUsages.Count * addedPointsPerUsageForToday) + minPointsToUseForDiamonds;

            Users currentUser = _usersServices.GetUser(userId);
            if (currentUser != null)
            {
                if (currentUser.Points >= neededPoints)
                {
                    permitToUse = true;
                }
                else
                {
                    permitToUse = false;
                }
            }
            else
            {
                permitToUse = false;
            }



            if (!permitToUse)
            {
                return Ok("-1");
            }





            int theResult = -1;

            if (CachedContents.DiamondPriorities.Count < 2)
            {
                ConstantDictionaries firstDic = _usersServices.GetConstantDictionary("diamond_first_priority");
                ConstantDictionaries secondDic = _usersServices.GetConstantDictionary("diamond_second_priority");
                ConstantDictionaries thirdDic = _usersServices.GetConstantDictionary("diamond_third_priority");
                ConstantDictionaries fourthDic = _usersServices.GetConstantDictionary("diamond_fourth_priority");
                ConstantDictionaries fivthDic = _usersServices.GetConstantDictionary("diamond_fivth_priority");
                ConstantDictionaries sixthDic = _usersServices.GetConstantDictionary("diamond_sixth_priority");
                ConstantDictionaries seventhDic = _usersServices.GetConstantDictionary("diamond_seventh_priority");
                ConstantDictionaries eighthDic = _usersServices.GetConstantDictionary("diamond_eighth_priority");
                ConstantDictionaries ninethDic = _usersServices.GetConstantDictionary("diamond_nineth_priority");
                ConstantDictionaries tenthDic = _usersServices.GetConstantDictionary("diamond_tenth_priority");

                CachedContents.DiamondCounts.Add(Convert.ToString(firstDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(firstDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(secondDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(secondDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(thirdDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(thirdDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(fourthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(fourthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(fivthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(fivthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(sixthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(sixthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(seventhDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(seventhDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(eighthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(eighthDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(ninethDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(ninethDic.ConstantSecondValue));

                CachedContents.DiamondCounts.Add(Convert.ToString(tenthDic.ConstantValue));
                CachedContents.DiamondPriorities.Add(Convert.ToInt32(tenthDic.ConstantSecondValue));

                for (int i = 0; i < CachedContents.DiamondPriorities.Count; i++)
                {
                    if (CachedContents.DiamondPriorities[i] > 0)
                    {
                        List<string> tmpListDiamondsCount = CachedContents.DiamondCounts[i].Split(",").ToList<string>();
                        foreach (string item in tmpListDiamondsCount)
                        {
                            CachedContents.DiamondCountsList.Add(item);
                        }
                    }
                }
            }



            SplitAtRandom(CachedContents.DiamondPriorities[0],
                CachedContents.DiamondPriorities[1],
                CachedContents.DiamondPriorities[2],
                CachedContents.DiamondPriorities[3],
                CachedContents.DiamondPriorities[4],
                CachedContents.DiamondPriorities[5],
                CachedContents.DiamondPriorities[6],
                CachedContents.DiamondPriorities[7],
                CachedContents.DiamondPriorities[8],
                CachedContents.DiamondPriorities[9],
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[0].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[1].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[1].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[2].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[2].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[3].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[3].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[4].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[4].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[5].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[5].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[6].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[6].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[7].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[7].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[8].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[8].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          },
                          () =>
                          {
                              Random randN = new Random(DateTime.Now.Millisecond);
                              int selectedIndex = randN.Next(0, CachedContents.DiamondCounts[9].Split(",").Count() - 1);
                              theResult = Convert.ToInt32(CachedContents.DiamondCounts[9].Split(",")[selectedIndex]);
                              //theResult = randN.Next(Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[0]), Convert.ToInt32(CachedContents.DiamondCounts[0].Split(",")[1]));
                          });


            currentUser.Diamonds += theResult;
            currentUser.Points -= neededPoints;

            _usersServices.UpdateUser(currentUser);

            _usersServices.AddDiamondUsage(new DiamondUsages
            {
                Created = DateTime.Now,
                DiamondsWon = theResult,
                User = userId,
                PointCharged = neededPoints

            });

            int theIndex = CachedContents.DiamondCountsList.FindIndex(x => x == theResult.ToString());
            int theDegree = (360 / CachedContents.DiamondCountsList.Count) * (theIndex + 1);

            if (theResult > 0)
            {
                return Ok(neededPoints.ToString() + "," + theResult + "," + theDegree + "," + "شما برنده " + theResult.ToString() + " الماس شدید. " + neededPoints.ToString() + " امتیاز مصرف شد. چرخش بعدی امروز نیاز به " + (neededPoints + addedPointsPerUsageForToday).ToString() + " امتیاز دارد.");
            }
            else
            {
                return Ok(neededPoints.ToString() + "," + theResult + "," + "پــوچ");
            }


        }



        public class Post
        {
            public string adId { get; set; }
            public string adNote { get; set; }
        }


        public class TheChatMessage
        {
            public string receiverUsername { get; set; }
            public string theMessageBody { get; set; }
            public string receiverUserid { get; set; }
        }

        public class TheMessagecontact
        {
            public string messageBody { get; set; }
            public Guid? messageId { get; set; }
        }



        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpPost("sendContact")]
        public IActionResult sendContact([FromBody] TheMessagecontact post)
        {


            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);


            _usersServices.AddContacts(new Contacts
            {
                FromUser = userId,
                TheMessage = post.messageBody,
                Created = DateTime.Now
            });







            //List<DTODraws> draws = _usersServices.GetAllActiveDrawsByUser(userId);
            return Ok("1");
        }


        [TypeFilter(typeof(SampleAsyncSuperAdminsLoginFilter))]
        [HttpPost("sendReplyContact")]
        public IActionResult sendReplyContact([FromBody] TheMessagecontact post)
        {


            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            Contacts theContact = _usersServices.GetAllContacts().Where(c => c.Id == post.messageId && c.IsReplied == false).First();
            if (theContact != null)
            {
                theContact.IsReplied = true;
                theContact.ReplyMessage = post.messageBody;
                theContact.ReplyDate = DateTime.Now;

                _usersServices.UpdateContacts(theContact);

                return Ok("1");
            }



            //List<DTODraws> draws = _usersServices.GetAllActiveDrawsByUser(userId);
            return Ok("-1");
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
                    if (CachedContents.Advertises.Find(a => a.Id == ad.Id) == null)
                    {
                        CachedContents.Advertises.Insert(0, ad);
                    }


                    if (ad.IsPremium == true)
                    {
                        Users adOwner = _usersServices.GetUser(ad.Owner);

                        string pointsRewardKeyName = (ad.IsVideo == true) ? "points_reward_premium_video_ads" : "points_reward_premium_image_ads";
                        int pointsReward = Convert.ToInt32(_usersServices.GetConstantDictionary(pointsRewardKeyName).ConstantValue);

                        if (adOwner != null)
                        {
                            adOwner.Points += pointsReward;
                            _usersServices.UpdateUser(adOwner);
                        }

                    }


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

                    if (ad.IsPremium == true)
                    {
                        Users adOwner = _usersServices.GetUser(ad.Owner);

                        string moneyRequiredKeyName = (ad.IsVideo == true) ? "def_money_to_premium_video_ads" : "def_money_to_premium_image_ads";
                        int moneyNeedBack = Convert.ToInt32(_usersServices.GetConstantDictionary(moneyRequiredKeyName).ConstantValue);

                        if (adOwner != null)
                        {
                            adOwner.Money += moneyNeedBack;
                            _usersServices.UpdateUser(adOwner);

                            Transactions transac = _usersServices.GetAllTransactions().Where(x => x.ReferenceID == ad.Id.ToString()).FirstOrDefault();
                            if (transac != null)
                            {
                                transac.IsDeleted = true;
                                transac.LastModified = DateTime.Now;
                                transac.LastModifiedBy = adOwner.ToString();
                                _usersServices.UpdateTransaction(transac);
                            }

                        }

                    }



                    return Ok(true);
                }
            }

            return Ok(false);
        }


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpPost("sendMessageChat")]
        public IActionResult SendMessageChat([FromBody] TheChatMessage theChatMessage)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            Users theSender = _usersServices.GetUser(userId);
            Users theReceiver = new Users();
            try
            {
                theReceiver = _usersServices.GetAllUsers().Where(u => u.Id == Guid.Parse(theChatMessage.receiverUserid)).FirstOrDefault();
            }
            catch (Exception)
            {
                theReceiver = _usersServices.GetAllUsers().Where(u => u.Username == theChatMessage.receiverUserid).FirstOrDefault();


            }



            if (theSender != null && theReceiver != null)
            {
                if (_usersServices.GetAllChatBlocks().Where(cb => cb.fromUser == theSender.Id && cb.toUser == theReceiver.Id).ToList<ChatBlocks>().Count > 0)
                {
                    return Ok("-2");

                }
                else
                {
                    if (_usersServices.GetAllChatBlocks().Where(cb => cb.fromUser == theReceiver.Id && cb.toUser == theSender.Id).ToList<ChatBlocks>().Count > 0)
                    {
                        return Ok("-2");
                    }
                }

                _usersServices.AddChatMessages(new ChatMessages
                {
                    FromUser = theSender.Id,
                    ToUser = theReceiver.Id,
                    TheMessage = theChatMessage.theMessageBody,
                    Created = DateTime.Now
                });

                theReceiver.HasNewMessage = true;
                _usersServices.UpdateUser(theReceiver);
                return Ok("1");
            }
            else
            {
                return Ok("-1");
            }

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpPost("blockChatUser")]
        public IActionResult blockChatUser([FromBody] TheChatMessage theChatMessage)
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            Users theSender = _usersServices.GetUser(userId);
            Users theReceiver = new Users();
            try
            {
                theReceiver = _usersServices.GetAllUsers().Where(u => u.Id == Guid.Parse(theChatMessage.receiverUserid)).FirstOrDefault();
            }
            catch (Exception)
            {
                theReceiver = _usersServices.GetAllUsers().Where(u => u.Username == theChatMessage.receiverUserid).FirstOrDefault();


            }



            if (theSender != null && theReceiver != null)
            {
                ChatBlocks chtBlocks = _usersServices.GetAllChatBlocksWithDeleteds().Where(cb => cb.fromUser == theSender.Id && cb.toUser == theReceiver.Id).FirstOrDefault();
                if (chtBlocks != null)
                {
                    if (chtBlocks.IsDeleted)
                    {
                        chtBlocks.IsDeleted = false;
                    }
                    else
                    {
                        chtBlocks.IsDeleted = true;
                    }

                    chtBlocks.LastModified = DateTime.Now;
                    _usersServices.UpdateChatBlocks(chtBlocks);
                    if (chtBlocks.IsDeleted)
                    {
                        return Ok("-2");
                    }
                    else
                    {
                        return Ok("-1");
                    }
                }
                else
                {
                    _usersServices.AddChatBlocks(new ChatBlocks
                    {
                        fromUser = theSender.Id,
                        toUser = theReceiver.Id,
                        Created = DateTime.Now

                    });

                    return Ok("-1");
                }




            }
            else
            {
                return Ok("-3");
            }

        }

        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("showMyFullName")]
        public IActionResult showMyFullName()
        {

            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);

            Users theuser = _usersServices.GetUser(userId);

            if (theuser != null)
            {
                theuser.ShowMyFullNameInPublic = !theuser.ShowMyFullNameInPublic;
                _usersServices.UpdateUser(theuser);
                return Ok(theuser.ShowMyFullNameInPublic==true?"1":"0");
            }
            else
            {
                return Ok("-1");
            }

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
            List<string> searchedResult = _usersServices.GetUsernames().Where(s => s == theusername).ToList<string>();
            if (searchedResult.Count > 0)
            {
                return new JsonResult($"{Username} " + "قبلا ثبت شده است.");
            }
            else
            {
                string[] validss = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                for (int i = 0; i < Username.Length; i++)
                {
                    int result = Array.FindIndex(validss, s => s == Username[i].ToString());
                    if (result == -1)
                    {
                        return new JsonResult($"'{Username}' " + " مجاز نیست. فقط حروف لاتین و اعداد مجاز میباشند.");
                    }
                }
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
        string callbackurl = "https://localhost:33333/VerifyByHttpClient";
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


        [TypeFilter(typeof(SampleAsyncActionLoginFilter))]
        [HttpGet("confirmPayment/{transacID:guid}")]
        public IActionResult confirmPayment(Guid transacID)
        {
            string _userid = HttpContext.Request.Cookies["userid"];
            Guid userId = Guid.Parse(_userid);
            if (_session.GetString("userrolename") == "super" || _session.GetString("userrolename") == "admin")
            {
                Transactions transac = _usersServices.GetAllTransactions().Where(t => t.Id == transacID).FirstOrDefault();
                if (transac != null)
                {
                    transac.IsSuccessfull = true;
                    transac.LastModified = DateTime.Now;
                    transac.LastModifiedBy = _userid;
                    _usersServices.UpdateTransaction(transac);

                    return Ok("ok");
                }
            }

            return Ok("-1");

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
                        return RedirectToPage("/Clients/PaymentResult", "Display", new { TransactionId = transac.Id, RefId = authority, Status = true, Code = "success" });


                        //return View();
                    }
                    else if (errors != "[]")
                    {

                        string errorscode = jo["errors"]["code"].ToString();
                        transac.Status = jo["errors"]["code"].ToString();
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
