using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Infrastructure.Services
{
    public static class UnixtimeExtensions
    {
        public static readonly DateTime UNIXTIME_ZERO_POINT = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Converts a Unix timestamp (UTC timezone by definition) into a DateTime object
        /// </summary>
        /// <param name="value">An input of Unix timestamp in seconds or milliseconds format</param>
        /// <param name="localize">should output be localized or remain in UTC timezone?</param>
        /// <param name="isInMilliseconds">Is input in milliseconds or seconds?</param>
        /// <returns></returns>
        public static DateTime FromUnixtime(this long value, bool localize = false, bool isInMilliseconds = true)
        {
            DateTime result;

            if (isInMilliseconds)
            {
                result = UNIXTIME_ZERO_POINT.AddMilliseconds(value);
            }
            else
            {
                result = UNIXTIME_ZERO_POINT.AddSeconds(value);
            }

            if (localize)
                return result.ToLocalTime();
            else
                return result;
        }

        /// <summary>
        /// Converts a DateTime object into a Unix time stamp
        /// </summary>
        /// <param name="value">any DateTime object as input</param>
        /// <param name="isInMilliseconds">Should output be in milliseconds or seconds?</param>
        /// <returns></returns>
        public static long ToUnixtime(this DateTime value, bool isInMilliseconds = true)
        {
            if (isInMilliseconds)
            {
                return (long)value.ToUniversalTime().Subtract(UNIXTIME_ZERO_POINT).TotalMilliseconds;
            }
            else
            {
                return (long)value.ToUniversalTime().Subtract(UNIXTIME_ZERO_POINT).TotalSeconds;
            }
        }
    }
    public class UsersServices : IUserServices
    {
        private readonly IUsersRepository _userRepo;
        private readonly IOnlineUsersRepository _onlineRepo;
        private readonly IAdverticeRepository _adverticeRepo;
        private readonly ILikersRepository _likersRepo;
        private readonly IViewersRepository _viewersRepo;
        private readonly IRolesRepository _rolesRepo;

        public static bool IsLoggedIn = false;

        public UsersServices(IUsersRepository repo, IOnlineUsersRepository onlineRepo, IAdverticeRepository adverticeRepo, ILikersRepository likersRepo, IViewersRepository viewersRepo, IRolesRepository rolesRepo)
        {
            _userRepo = repo;
            _onlineRepo = onlineRepo;
            _adverticeRepo = adverticeRepo;
            _likersRepo = likersRepo;
            _viewersRepo = viewersRepo;
            _rolesRepo = rolesRepo;
        }
        public List<String> GetUsernames()
        {
            Users[] users = _userRepo.GetAll().ToArray();
            List<String> usernames = new List<string>();
            foreach (Users item in users)
            {
                usernames.Add(item.Username);
            }
            return usernames;

        }
        public List<String> GetCellphones()
        {
            Users[] users = _userRepo.GetAll().ToArray();
            List<String> cellphones = new List<string>();
            foreach (Users item in users)
            {
                cellphones.Add(item.Cellphone);
            }
            return cellphones;

        }
        public Users GetUser(Guid id)
        {
            return _userRepo.GetById(id);
        }
        public Users GetUserByUsername(string username)
        {
            return _userRepo.GetAll().Where(u => u.Username == username).SingleOrDefault();
        }
        public List<Users> GetUsers(int pageNumber)
        {
            int pageSize = 2;
            int skip = pageSize * (pageNumber - 1);
            if (_userRepo.GetAll().Count < pageSize)
                pageSize = _userRepo.GetAll().Count;
            return _userRepo.GetAll()
              .Skip(skip)
              .Take(pageSize).ToList();
            return this.GetUsers(pageNumber);
        }
        public List<Users> GetAllUsers()
        {
            return _userRepo.GetAll().ToList<Users>();
        }

        public Guid AddUser(Users usr)
        {
            _userRepo.Add(usr);
            return usr.Id;
        }
        public bool UpdateUser(Users user)
        {
            _userRepo.Update(user);
            
            return true;
        }

        public bool RegisterdSuccessfullyAndLogin(OnlineUsers onlineUsers)
        {
            return LoginSuccessfully(onlineUsers);
        }
        public bool LoginSuccessfully(OnlineUsers onlineUsers)
        {
            OnlineUsers[] ons= _onlineRepo.GetAll().Where(o => o.User == onlineUsers.User && o.UserDevice == onlineUsers.UserDevice).ToArray<OnlineUsers>();
            foreach (OnlineUsers item in ons)
            {
                _onlineRepo.Delete(item);
            }
            //_onlineRepo.RemoveOnlineUsersByUserDeviceAndUserID(onlineUsers.UserDevice, onlineUsers.User.Id);
            _onlineRepo.Add(onlineUsers);// .Save(onlineUsers);
            return true;
        }



        /// <summary>
        /// checks if user with provided token has an online record in DB or not
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="token">Token in client device</param>
        /// <returns></returns>
        public bool CheckUserLogin(Guid userId, string token)
        {
            // check if user is exist or not
            Users usr = _userRepo.GetById(userId);
            if (usr != null)
            {
                // check if user is activated or not
                if (usr.IsActivated)
                {
                    // check if provided token is valid in DB or not
                    OnlineUsers _usr = _onlineRepo.GetAll().Where(o => o.Guid == token).FirstOrDefault(); //GetOnlineUserByGuid(token);
                    if (_usr != null)
                    {
                        if (_usr.User == userId)
                        {
                            return true;
                        }
                    }

                }
            }

            return false;
        }

        public Users GetUserByCellphone(string cellphone)
        {
            return _userRepo.GetAll().Where(u => u.Cellphone == cellphone).SingleOrDefault();
        }

        public Guid AddAvertise(Advertise advertise, Guid userId)
        {
            if (advertise.ViewQuota != -1)
            {
                advertise.RemainedViewQuota = advertise.ViewQuota;
            }

            return _adverticeRepo.Add(advertise).Id;
        }

        public List<DTOAdvertise> GetAdvertises(Guid userID)
        {
            // get current user
            Users user = _userRepo.GetById(userID);

            // get all ads if owner quota is not ended and ads is not expired
            List<Advertise> result = _adverticeRepo.GetAll()
                .Where(a => a.RemainedViewQuota != -1 && a.Expiracy <= DateTime.Now && a.IsAvtivated)
                .OrderByDescending(l => l.CreationDate)
                .ToList<Advertise>();

            // create return data model object
            List<DTOAdvertise> dTOAdvertise = new List<DTOAdvertise>();

            // prepare returning ads
            foreach (Advertise item in result)
            {
                // checks if ads quota is not unlimited and if current viewer is not the owner of ad
                if (item.ViewQuota != -1 && userID != item.Owner)
                {
                    // then decrease remained view quota 1 unit
                    item.RemainedViewQuota -= 1;
                    _adverticeRepo.Update(item);
                }

                // check if current user is not ad owner
                if (userID != item.Owner)
                {
                    // then add current view for ad
                    _viewersRepo.Add(new Viewers { Advertise = item.Id, ViewedBy = userID });

                }

                // prepare likers of current ad
                IList<Likers> _likers = _likersRepo.GetAll().Where(l=>l.Advertise==item.Id).ToList<Likers>();
                IList<Viewers> _viewers = _viewersRepo.GetAll().Where(v=>v.Advertise==item.Id).ToList<Viewers>();

                // map ad, likers and viewers to ad DTO
                DTOAdvertise _dtoAds = new DTOAdvertise();
                _dtoAds.AdvertiseID = item.Id;
                _dtoAds.Caption = item.Caption;
                _dtoAds.Name = item.Name;
                _dtoAds.CreationDate = item.CreationDate.ToString();
                _dtoAds.Likers = _likers;
                _dtoAds.MediaSourceURL = item.MediaSourceURL;
                _dtoAds.Owner = GetUser(item.Owner);
                _dtoAds.Viewers = _viewers;
                _dtoAds.IsVideo = item.IsVideo;
                _dtoAds.LikerCount = _likers.Count;
                _dtoAds.ViewerCount = _viewers.Count;
                _dtoAds.LikeReward = item.LikeReward;
                _dtoAds.ViewReward = item.ViewReward;
                _dtoAds.YouLiked = (_likersRepo.GetAll().Where(l => l.Advertise==item.Id && l.LikedBy == userID).ToList<Likers>().Count==0) ? false : true;

                dTOAdvertise.Add(_dtoAds);
            }


            return dTOAdvertise;
        }

        public Likers AddLikeToAdvertise(Guid advertiseID, Guid userID)
        {
            //Advertise ad = _adverticeRepo.GetById(advertiseID);
            //Users usr = _userRepo.GetById(userID);
            return _likersRepo.Add(new Likers { Advertise= advertiseID, LikedBy= userID });
        }

        public bool RemoveLikeFromAdvertise(Guid advertiseID, Guid UserID)
        {
            //Advertise ad = _adverticeRepo.GetById(advertiseID);
            //Users usr = _userRepo.GetById(UserID);
            Likers lk = _likersRepo.GetAll().Where(l => l.Advertise == advertiseID && l.LikedBy == UserID).FirstOrDefault();
            _likersRepo.Delete(lk);
            return true;
        }

        bool IUserServices.DoLikeAdvertiseByUserID(Guid advertiseID, Guid UserID)
        {
            // get liked ads
            Advertise _ad = _adverticeRepo.GetById(advertiseID);
            if (_ad != null)
            {
                // check if current user liked the ads before or not
                List<Likers> prevLikes = _likersRepo.GetAll().Where(l => l.Advertise == advertiseID)// GetLikes(_ad)
                    .Where(l => l.LikedBy == UserID)
                    .ToList<Likers>();

                if (prevLikes.Count == 0)
                {
                    // get liker user
                    Users _liker = _userRepo.GetById(UserID);

                    // add like
                    _likersRepo.Add( new Likers { Advertise=advertiseID, LikedBy=UserID});

                    // check if liker is not ads owner
                    if (_ad.Owner != UserID)
                    {
                        // then add ads like reward to liker
                        _liker.Points += _ad.LikeReward;
                        _userRepo.Update(_liker);
                    }

                    return true;
                }
            }
            return false;
        }

        bool IUserServices.LogOut(Guid UserID, string GUID)
        {
            OnlineUsers[] onlines = _onlineRepo.GetAll().Where(o => o.User == UserID && o.Guid == GUID).ToArray<OnlineUsers>();
            foreach (OnlineUsers item in onlines)
            {
                _onlineRepo.Delete(item);
            }
            return true; //_onlineRepo.RemoveOnlineUsersByUseridAndToken(UserID, GUID);
        }

        Roles IUserServices.AddRole(Roles roles)
        {
            Roles _r = _rolesRepo.Add(roles);
            //_rolesRepo.SaveChanges();
            return _r;

        }
    }
}
