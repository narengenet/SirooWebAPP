﻿using AutoMapper;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;

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
        private readonly IUsersRolesRepository _usrRolesRepo;
        private readonly IDrawsRepository _drawsRepo;
        private readonly IPrizesRepository _prizRepo;
        private readonly IConstantDictionariesRepository _constRepo;
        private readonly IPointUsagesRepository _pointUsageRepo;
        private readonly IDonnationTickets _donnationTicketRepo;
        private readonly IPrizesWinnersRepository _prizeWinnersRepo;

        private readonly IMapper _mapper;



        public static bool IsLoggedIn = false;

        public UsersServices(IUsersRepository repo,
            IOnlineUsersRepository onlineRepo,
            IAdverticeRepository adverticeRepo,
            ILikersRepository likersRepo,
            IViewersRepository viewersRepo,
            IRolesRepository rolesRepo,
            IUsersRolesRepository usrRolesRepo,
            IDrawsRepository drawsRepo,
            IPrizesRepository prizeRepo,
            IConstantDictionariesRepository constRepo,
            IPointUsagesRepository pointUsageRepo,
            IDonnationTickets donnationTicketRepo,
            IPrizesWinnersRepository prizesWinnersRepository,
            IMapper mapper
            )
        {
            _userRepo = repo;
            _onlineRepo = onlineRepo;
            _adverticeRepo = adverticeRepo;
            _likersRepo = likersRepo;
            _viewersRepo = viewersRepo;
            _rolesRepo = rolesRepo;
            _usrRolesRepo = usrRolesRepo;
            _drawsRepo = drawsRepo;
            _prizRepo = prizeRepo;
            _constRepo = constRepo;
            _pointUsageRepo = pointUsageRepo;
            _donnationTicketRepo = donnationTicketRepo;
            _prizeWinnersRepo = prizesWinnersRepository;

            _mapper = mapper;
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
            return GetAllUsers().Where(u => u.Id == id).FirstOrDefault();


        }
        public Users GetNotDeletedUser(Guid id)
        {
            return _userRepo.GetAll().Where(u => u.Id == id && u.IsDeleted == false).FirstOrDefault();
        }
        public Users GetUserByUsername(string username)
        {
            return _userRepo.GetAll().Where(u => u.Username == username).SingleOrDefault();
        }
        public List<Users> GetUsers(int pageNumber)
        {
            int pageSize = 2;
            int skip = pageSize * (pageNumber - 1);
            if (this.GetAllUsers().Count < pageSize)
                pageSize = this.GetAllUsers().Count;
            return this.GetAllUsers()
              .Skip(skip)
              .Take(pageSize).ToList();
            return this.GetUsers(pageNumber);
        }
        public List<Users> GetAllUsers()
        {
            return _userRepo.GetAll().Where(u => u.IsDeleted == false && u.IsActivated == true).ToList<Users>();
        }
        public DTOUserProfile GetUserProfile(Guid userId)
        {
            Users usr = _userRepo.GetById(userId);
            DTOUserProfile dtoUser = _mapper.Map<DTOUserProfile>(usr);
            if (usr != null)
            {
                if (usr.Inviter != null)
                {
                    Guid inviterId = Guid.Parse(usr.Inviter.ToString());
                    Users _inviter = _userRepo.GetById(inviterId);
                    dtoUser.InviterUsername = _inviter.Username;
                }

                List<Users> _inviteds = _userRepo.GetAll().Where(u => u.Inviter == userId).ToList<Users>();
                dtoUser.Inviteds = new List<DTOUserProfile>();
                if (_inviteds.Count != 0)
                {
                    foreach (Users item in _inviteds)
                    {
                        Roles _r = GetUserRoles(item.Id).OrderBy(u => u.Priority).First();
                        DTOUserProfile _u = new DTOUserProfile();
                        _u.Username = item.Username;
                        if (_r != null)
                        {
                            _u.RoleName = _r.RoleName;
                        }
                        dtoUser.Inviteds.Add(_u);
                    }

                }
                dtoUser.CreationDate = Convert.ToDateTime(usr.Created.ToString());
                dtoUser.CellPhone = usr.Cellphone;



            }
            return dtoUser;
        }
        public List<DTOUserSmall> GetAllLesserPriorityUsers(Guid requesterUserId)
        {
            Roles requestedUserHighestRole = GetUserRoles(requesterUserId).OrderBy(r => r.Priority).First();
            List<DTOUserSmall> fullEntries = GetAllUsers()
                .Join(
                    GetAllUsersRoles(),
                    user => user.Id,
                    userRole => userRole.User,
                    (user, userRole) => new
                    {
                        userId = user.Id,
                        userName = user.Username,
                        roleId = userRole.Role
                    }
                )
                .Join(
                    GetAllRoles(),
                    combinedEntry => combinedEntry.roleId,
                    roles => roles.Id,
                    (combinedEntry, roles) => new
                    {
                        UserId = combinedEntry.userId,
                        Username = combinedEntry.userName,
                        Priority = roles.Priority
                    }
                )
                //.Where(fullEntry => fullEntry.Priority==5)
                .Where(fullEntry => fullEntry.Priority > requestedUserHighestRole.Priority)
                .Select(x => new DTOUserSmall { UserId = x.UserId, Username = x.Username })
                .DistinctBy(x => x.Username)
                .ToList<DTOUserSmall>();

            return fullEntries;
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
        public bool RemovePermUser(Users user)
        {
            _userRepo.Delete(user);
            return true;
        }

        public bool RegisterdSuccessfullyAndLogin(OnlineUsers onlineUsers)
        {
            return LoginSuccessfully(onlineUsers);
        }
        public bool LoginSuccessfully(OnlineUsers onlineUsers)
        {
            OnlineUsers[] ons = _onlineRepo.GetAll().Where(o => o.User == onlineUsers.User && o.UserDevice == onlineUsers.UserDevice).ToArray<OnlineUsers>();
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
            Users usr = GetUser(userId);
            if (usr != null)
            {
                // check if user is activated or not
                if (usr.IsActivated && usr.IsDeleted == false)
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
            List<Advertise> result = _adverticeRepo.GetAll().Where(a => a.RemainedViewQuota != -1 && a.Expiracy <= DateTime.Now && a.IsAvtivated && a.IsDeleted == false && a.IsRejected == false)
                .Join(
                    _userRepo.GetAll().Where(u => u.IsActivated == true && u.IsDeleted == false).ToList<Users>(),
                    ads => ads.Owner,
                    users => users.Id,
                    (ads, users) => ads
                    //new Advertise { Id=ads.Id, Name=ads.Name, Owner=ads.Owner, Caption=ads.Caption, Created=ads.Created, CreatedBy=ads.CreatedBy, CreationDate=ads.CreationDate, Expiracy=ads.Expiracy, IsAvtivated=ads.IsAvtivated, IsDeleted=ads.IsDeleted, IsSpecial=ads.IsSpecial, IsVideo=ads.IsVideo, LastModified=ads.LastModified, LastModifiedBy=ads.LastModifiedBy, LikeReward=ads.LikeReward, MediaSourceURL=ads.MediaSourceURL, RemainedViewQuota=ads.RemainedViewQuota, ViewQuota=ads.ViewQuota, ViewReward=ads.ViewReward}
                )
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
                IList<Likers> _likers = _likersRepo.GetAll().Where(l => l.Advertise == item.Id).ToList<Likers>();
                IList<Viewers> _viewers = _viewersRepo.GetAll().Where(v => v.Advertise == item.Id).ToList<Viewers>();

                // map ad, likers and viewers to ad DTO
                DTOAdvertise _dtoAds = new DTOAdvertise();

                _dtoAds = _mapper.Map<DTOAdvertise>(item);

                _dtoAds.AdvertiseID = item.Id;
                //_dtoAds.Caption = item.Caption;
                //_dtoAds.Name = item.Name;
                _dtoAds.CreationDate = item.CreationDate.ToString();
                _dtoAds.Likers = _likers;
                _dtoAds.MediaSourceURL = item.MediaSourceURL;
                _dtoAds.Owner = _mapper.Map<DTOUser>(GetUser(item.Owner));
                _dtoAds.Viewers = _viewers;
                _dtoAds.IsVideo = item.IsVideo;
                _dtoAds.LikerCount = _likers.Count;
                _dtoAds.ViewerCount = _viewers.Count;
                _dtoAds.LikeReward = item.LikeReward;
                _dtoAds.ViewReward = item.ViewReward;
                _dtoAds.YouLiked = (_likersRepo.GetAll().Where(l => l.Advertise == item.Id && l.LikedBy == userID).ToList<Likers>().Count == 0) ? false : true;

                dTOAdvertise.Add(_dtoAds);
            }


            return dTOAdvertise;
        }

        public List<DTOAdvertise> GetMyAdvertises(Guid userID)
        {

            // get current user
            Users user = _userRepo.GetById(userID);


            // get all ads if owner quota is not ended and ads is not expired
            List<Advertise> result = _adverticeRepo.GetAll().Where(a => a.Owner == userID && a.IsDeleted == false)
                .Join(
                    _userRepo.GetAll().Where(u => u.IsActivated == true && u.IsDeleted == false).ToList<Users>(),
                    ads => ads.Owner,
                    users => users.Id,
                    (ads, users) => ads
                    //new Advertise { Id=ads.Id, Name=ads.Name, Owner=ads.Owner, Caption=ads.Caption, Created=ads.Created, CreatedBy=ads.CreatedBy, CreationDate=ads.CreationDate, Expiracy=ads.Expiracy, IsAvtivated=ads.IsAvtivated, IsDeleted=ads.IsDeleted, IsSpecial=ads.IsSpecial, IsVideo=ads.IsVideo, LastModified=ads.LastModified, LastModifiedBy=ads.LastModifiedBy, LikeReward=ads.LikeReward, MediaSourceURL=ads.MediaSourceURL, RemainedViewQuota=ads.RemainedViewQuota, ViewQuota=ads.ViewQuota, ViewReward=ads.ViewReward}
                )
                .OrderByDescending(l => l.CreationDate)
                .ToList<Advertise>();

            // create return data model object
            List<DTOAdvertise> dTOAdvertise = new List<DTOAdvertise>();

            // prepare returning ads
            foreach (Advertise item in result)
            {

                // prepare likers of current ad
                IList<Likers> _likers = _likersRepo.GetAll().Where(l => l.Advertise == item.Id).ToList<Likers>();
                IList<Viewers> _viewers = _viewersRepo.GetAll().Where(v => v.Advertise == item.Id).ToList<Viewers>();

                // map ad, likers and viewers to ad DTO
                DTOAdvertise _dtoAds = new DTOAdvertise();

                _dtoAds = _mapper.Map<DTOAdvertise>(item);

                _dtoAds.AdvertiseID = item.Id;
                //_dtoAds.Caption = item.Caption;
                //_dtoAds.Name = item.Name;
                _dtoAds.CreationDate = item.CreationDate.ToString();
                _dtoAds.Likers = _likers;
                _dtoAds.MediaSourceURL = item.MediaSourceURL;
                _dtoAds.Owner = _mapper.Map<DTOUser>(GetUser(item.Owner));
                _dtoAds.Viewers = _viewers;
                _dtoAds.IsVideo = item.IsVideo;
                _dtoAds.LikerCount = _likers.Count;
                _dtoAds.ViewerCount = _viewers.Count;
                _dtoAds.LikeReward = item.LikeReward;
                _dtoAds.ViewReward = item.ViewReward;
                _dtoAds.IsAvtivated = item.IsAvtivated;
                _dtoAds.YouLiked = (_likersRepo.GetAll().Where(l => l.Advertise == item.Id && l.LikedBy == userID).ToList<Likers>().Count == 0) ? false : true;

                dTOAdvertise.Add(_dtoAds);
            }


            return dTOAdvertise;
        }
        public bool UpdateAdvertisement(Advertise ads)
        {
            _adverticeRepo.Update(ads);
            return true;
        }
        public Advertise GetAdvertise(Guid adsID)
        {
            return _adverticeRepo.GetAll().Where(a => a.Id == adsID && a.IsDeleted == false).FirstOrDefault();
        }
        public List<DTOAdvertise> GetPendingAdvertises(Guid userID)
        {

            // get current user
            Users user = _userRepo.GetById(userID);


            // get all ads if owner quota is not ended and ads is not expired
            List<Advertise> result = _adverticeRepo.GetAll().Where(a => a.IsDeleted == false && a.IsAvtivated == false)
                .Join(
                    _userRepo.GetAll().Where(u => u.IsActivated == true && u.IsDeleted == false).ToList<Users>(),
                    ads => ads.Owner,
                    users => users.Id,
                    (ads, users) => ads
                    //new Advertise { Id=ads.Id, Name=ads.Name, Owner=ads.Owner, Caption=ads.Caption, Created=ads.Created, CreatedBy=ads.CreatedBy, CreationDate=ads.CreationDate, Expiracy=ads.Expiracy, IsAvtivated=ads.IsAvtivated, IsDeleted=ads.IsDeleted, IsSpecial=ads.IsSpecial, IsVideo=ads.IsVideo, LastModified=ads.LastModified, LastModifiedBy=ads.LastModifiedBy, LikeReward=ads.LikeReward, MediaSourceURL=ads.MediaSourceURL, RemainedViewQuota=ads.RemainedViewQuota, ViewQuota=ads.ViewQuota, ViewReward=ads.ViewReward}
                )
                .OrderByDescending(l => l.CreationDate)
                .ToList<Advertise>();

            // create return data model object
            List<DTOAdvertise> dTOAdvertise = new List<DTOAdvertise>();

            // prepare returning ads
            foreach (Advertise item in result)
            {

                // prepare likers of current ad
                IList<Likers> _likers = _likersRepo.GetAll().Where(l => l.Advertise == item.Id).ToList<Likers>();
                IList<Viewers> _viewers = _viewersRepo.GetAll().Where(v => v.Advertise == item.Id).ToList<Viewers>();

                // map ad, likers and viewers to ad DTO
                DTOAdvertise _dtoAds = new DTOAdvertise();

                _dtoAds = _mapper.Map<DTOAdvertise>(item);

                _dtoAds.AdvertiseID = item.Id;
                //_dtoAds.Caption = item.Caption;
                //_dtoAds.Name = item.Name;
                _dtoAds.CreationDate = item.CreationDate.ToString();
                _dtoAds.Likers = _likers;
                _dtoAds.MediaSourceURL = item.MediaSourceURL;
                _dtoAds.Owner = _mapper.Map<DTOUser>(GetUser(item.Owner));
                _dtoAds.Viewers = _viewers;
                _dtoAds.IsVideo = item.IsVideo;
                _dtoAds.LikerCount = _likers.Count;
                _dtoAds.ViewerCount = _viewers.Count;
                _dtoAds.LikeReward = item.LikeReward;
                _dtoAds.ViewReward = item.ViewReward;
                _dtoAds.YouLiked = (_likersRepo.GetAll().Where(l => l.Advertise == item.Id && l.LikedBy == userID).ToList<Likers>().Count == 0) ? false : true;

                dTOAdvertise.Add(_dtoAds);
            }


            return dTOAdvertise;
        }

        public bool DeleteAdvertise(Guid postID, Guid userId)
        {
            Advertise ads = _adverticeRepo.GetAll().Where(a => a.Id == postID && a.IsDeleted == false).FirstOrDefault();
            if (ads != null)
            {
                // does deleter is owner ?
                if (ads.Owner != userId)
                {
                    Roles deleterRole = GetUserRoles(userId).OrderBy(r => r.Priority).First();
                    // deleter is not owner but is deleter admin or super?
                    if (deleterRole.RoleName == "admin" || deleterRole.RoleName == "super")
                    {
                        // remove ads and set lastmodifier to admin or super which is deleting
                        ads.IsDeleted = true;
                        ads.LastModified = DateTime.Now;
                        ads.LastModifiedBy = userId.ToString();
                        _adverticeRepo.Update(ads);
                        return true;
                    }

                    // deleter is not owner and is not admin or super
                    // *** penetration risk ***
                    return false;
                }

                // owner is deleting the ads
                ads.IsDeleted = true;
                ads.LastModified = DateTime.Now;
                ads.LastModifiedBy = userId.ToString();
                _adverticeRepo.Update(ads);
                return true;
            }
            // ads is null
            // *** penetration risk ***
            return false;
        }

        public Likers AddLikeToAdvertise(Guid advertiseID, Guid userID)
        {
            //Advertise ad = _adverticeRepo.GetById(advertiseID);
            //Users usr = _userRepo.GetById(userID);
            return _likersRepo.Add(new Likers { Advertise = advertiseID, LikedBy = userID });
        }

        public bool RemoveLikeFromAdvertise(Guid advertiseID, Guid UserID)
        {
            //Advertise ad = _adverticeRepo.GetById(advertiseID);
            //Users usr = _userRepo.GetById(UserID);
            Likers lk = _likersRepo.GetAll().Where(l => l.Advertise == advertiseID && l.LikedBy == UserID).FirstOrDefault();
            _likersRepo.Delete(lk);
            return true;
        }

        int IUserServices.DoLikeAdvertiseByUserID(Guid advertiseID, Guid UserID)
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
                    _likersRepo.Add(new Likers { Advertise = advertiseID, LikedBy = UserID });

                    // check if liker is not ads owner
                    if (_ad.Owner != UserID)
                    {
                        // then add ads like reward to liker
                        _liker.Points += _ad.LikeReward;
                        _userRepo.Update(_liker);
                        return _ad.LikeReward;
                    }

                    return 0;
                }
            }
            return -1;
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

        public List<Roles> GetAllRoles()
        {
            return _rolesRepo.GetAll().ToList<Roles>();
        }
        public Roles GetRole(Guid roleId)
        {
            return _rolesRepo.GetById(roleId);
        }

        Roles IUserServices.GetRoleByName(string Name)
        {
            return GetAllRoles().Where(r => r.RoleName == Name).FirstOrDefault();
        }

        public List<UsersRoles> GetAllUsersRoles()
        {
            return _usrRolesRepo.GetAll().Where(ur => ur.IsDeleted == false).ToList<UsersRoles>();
        }
        public List<UsersRoles> GetAllPermenantUserRoles(Guid userId)
        {
            return _usrRolesRepo.GetAll().Where(ur => ur.User == userId).ToList<UsersRoles>();
        }
        public UsersRoles AddUserToRole(UsersRoles userRole)
        {
            return _usrRolesRepo.Add(userRole);
        }
        bool IUserServices.RemoveUserFromRole(UsersRoles userRole, Guid removedBy)
        {
            userRole.IsDeleted = true;
            userRole.LastModifiedBy = removedBy.ToString();
            this.UpdateUserRole(userRole);
            return true;
        }
        public void UpdateUserRole(UsersRoles usersRoles)
        {
            _usrRolesRepo.Update(usersRoles);
        }

        List<Draws> IUserServices.GetAllDraws()
        {
            return _drawsRepo.GetAll().ToList<Draws>();
        }
        public List<DTODraws> GetAllActiveDrawsByUser(Guid userId)
        {
            // get all ads if owner quota is not ended and ads is not expired
            List<Draws> result = _drawsRepo.GetAll()
                .Join(
                    _userRepo.GetAll().Where(u => u.IsActivated == true && u.IsDeleted == false).ToList<Users>(),
                    draws => draws.Owner,
                    users => users.Id,
                    (draws, users) => draws
                )
                .Where(d => d.IsActivated == true && d.IsDeleted == false)
                .OrderBy(d => d.StartDate)
                .ToList<Draws>();




            //List<DTODraws> _draws = _mapper.Map<List<DTODraws>>(_drawsRepo.GetAll().OrderBy(d => d.StartDate));
            List<DTODraws> _draws = _mapper.Map<List<DTODraws>>(result);
            List<DTOUser> allUsers = _mapper.Map<List<DTOUser>>(_userRepo.GetAll().Where(u => u.IsDeleted == false && u.IsActivated == true).OrderByDescending(u => u.Points).ToList<Users>());

            foreach (DTODraws item in _draws)
            {
                List<DTOPrize> _p = _mapper.Map<List<DTOPrize>>(GetPrizesByDraw(item.DrawId).OrderBy(p => p.Priority));
                item.Owner = _mapper.Map<DTOUser>(GetUser(item.OwnerId));
                item.Prizes = (_p);
                if (item.IsFinished)
                {
                    item.PrizeWinners = GetAllPrizeWinnersByDrawId(item.DrawId);
                }
                else
                {
                    item.PrizeWinners = allUsers;
                }

            }





            return _draws;

        }

        Draws IUserServices.AddDraw(Draws draw)
        {
            return _drawsRepo.Add(draw);
        }

        bool IUserServices.UpdateDraw(Draws draw)
        {
            _drawsRepo.Update(draw);
            return true;
        }

        public List<Prizes> GetAllPrizes()
        {
            return _prizRepo.GetAll().Where(p => p.IsDeleted == false && p.IsActivated == true).ToList<Prizes>();
        }

        public Prizes AddPrize(Prizes prize)
        {
            return _prizRepo.Add(prize);
        }
        public bool RemovePrize(Prizes prize, Guid removedBy)
        {
            prize.IsDeleted = true;
            prize.LastModifiedBy = removedBy.ToString();
            this.UpdatePrize(prize);
            return true;
        }
        public bool UpdatePrize(Prizes prize)
        {
            _prizRepo.Update(prize);
            return true;
        }
        public List<Prizes> GetPrizesByDraw(Guid drawId)
        {
            return GetAllPrizes().Where(p => p.Draw == drawId).ToList<Prizes>();
        }

        public List<Roles> GetUserRoles(Guid userId)
        {
            List<UsersRoles> ur = GetAllUsersRoles().Where(ur => ur.User == userId).ToList<UsersRoles>();
            List<Roles> roles = new List<Roles>();
            foreach (UsersRoles item in ur)
            {
                roles.Add(GetRole(item.Role));
            }
            return roles;
        }


        public List<ConstantDictionaries> GetAllConstantDictionaries()
        {
            return _constRepo.GetAll().Where(c => c.IsDeleted == false && c.IsActive == true).ToList<ConstantDictionaries>();
        }

        public ConstantDictionaries GetConstantDictionary(string key)
        {
            return GetAllConstantDictionaries().Where(c => c.ConstantKey == key).FirstOrDefault();
        }



        public List<PointUsages> GetAllPointUsages()
        {
            return _pointUsageRepo.GetAll().Where(p => p.IsDeleted == false && p.IsUsed == true).ToList<PointUsages>();
        }
        public List<PointUsages> GetAllUsedPointByDonner(Guid donnerId)
        {
            return GetAllPointUsages().Where(p => p.Donner == donnerId).ToList<PointUsages>();
        }
        public bool UsePoint(Guid donnationTicketId, Guid donnerId, Guid receiverId, long point, bool isCredit)
        {
            _pointUsageRepo.Add(new PointUsages { DonnationTicket = donnationTicketId, Donner = donnerId, Receiver = receiverId, Value = point, IsUsed = true, Created = DateTime.Now, IsCredit = isCredit });
            return true;
        }

        public List<DonnationTickets> GetAllDonnationTickets()
        {
            return _donnationTicketRepo.GetAll().Where(t => t.IsDeleted == false).ToList<DonnationTickets>();
        }

        public DonnationTickets GetDonnationTicket(Guid ticketId)
        {
            return GetAllDonnationTickets().Where(t => t.Id == ticketId).FirstOrDefault();
        }

        public bool UpdateDonnationTicket(DonnationTickets donnationTicket)
        {
            _donnationTicketRepo.Update(donnationTicket);
            return true;
        }

        Guid IUserServices.AddDonnationTicket(DonnationTickets donnationTicket)
        {
            _donnationTicketRepo.Add(donnationTicket);
            return donnationTicket.Id;
        }
        public bool removeDonnationTicket(Guid donnationId,Guid userId)
        {
            DonnationTickets _ticket= _donnationTicketRepo.GetById(donnationId);
            if (_ticket!=null)
            {
                if (_ticket.Donner==userId)
                {
                    _ticket.IsDeleted = true;
                    _ticket.LastModified = DateTime.Now;
                    _ticket.LastModifiedBy = userId.ToString();
                    //_donnationTicketRepo.Update(_ticket);
                    UpdateDonnationTicket(_ticket);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public List<DTOUser> GetAllPrizeWinnersByDrawId(Guid drawId)
        {
            return _prizeWinnersRepo.GetAll().Where(p => p.Draw == drawId)
                .Join(
                    GetAllUsers(),
                    prizes => prizes.User,
                    usr => usr.Id,
                    (prizes, usr) => new DTOUser
                    {
                        Name = usr.Name,
                        Family = usr.Family,
                        UserId = usr.Id,
                        Points = prizes.WiningPoint,
                        Username = usr.Username,
                        IsActivated = usr.IsActivated,
                        ProfileMediaURL = usr.ProfileMediaURL
                    }
                ).OrderByDescending(u => u.Points)
                .ToList<DTOUser>();
        }

        bool IUserServices.AddPrizeWinner(Guid drawId)
        {
            List<Prizes> prizes = GetAllPrizes().Where(p => p.Draw == drawId).OrderBy(p => p.Priority).ToList<Prizes>();
            int prizesWinnersCount = 0;
            foreach (Prizes item in prizes)
            {
                prizesWinnersCount += item.WinnerCount;
            }

            List<Users> winners = GetAllUsers().OrderByDescending(u => u.Points).ToList<Users>();

            int indx = 0;

            //for (int i = 0; i < prizesWinnersCount; i++)
            //{
            do
            {
                foreach (Prizes item in prizes)
                {
                    for (int j = 0; j < item.WinnerCount; j++)
                    {

                        PrizesWinners _pw = new PrizesWinners { Prize = item.Id, User = winners[indx].Id, WiningPoint = winners[indx].Points, WiningDate = DateTime.Now, Draw = drawId };
                        _prizeWinnersRepo.Add(_pw);
                        //winners[indx].Points = 0;
                        //_userRepo.Update(winners[indx]);
                        indx += 1;
                    }
                }
            } while (indx < prizesWinnersCount);
            //}
            _userRepo.GetAll().ToList().ForEach(u => u.Points = 0);
            return true;
        }
    }
}
