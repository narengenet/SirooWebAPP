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
        private readonly ITransactionsRepository _transactionsRepo;
        private readonly IPurchasesRepository _purchasesRepository;
        private readonly ITransactionPercentsRepository _transactionPercentsRepository;
        private readonly IChipsRepository _chipsRepo;

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
            ITransactionsRepository transactionsRepository,
            IPurchasesRepository purchasesRepository,
            ITransactionPercentsRepository transactionPercentsRepository,
            IChipsRepository chipsRepo,
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
            _transactionsRepo = transactionsRepository;
            _purchasesRepository = purchasesRepository;
            _transactionPercentsRepository = transactionPercentsRepository;
            _chipsRepo = chipsRepo;

            _mapper = mapper;
        }
        public List<String> GetUsernames()
        {
            Users[] users = _userRepo.GetAll().ToArray();
            List<string> allusernames = _userRepo.GetAll().Select(u => u.Username).ToList<string>();
            return allusernames;
            //List<String> usernames = new List<string>();
            //foreach (Users item in users)
            //{
            //    usernames.Add(item.Username);
            //}
            //return usernames;

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
        public List<Users> GetNotDeletedUsers()
        {
            return _userRepo.GetAll().Where(u => u.IsDeleted == false).ToList<Users>();
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
        public List<Users> GetAllDeletedUsers()
        {
            return _userRepo.GetAll().Where(u => u.IsDeleted == true).ToList<Users>();
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
                        Roles _r = GetUserRoles(item.Id).OrderBy(u => u.Priority).FirstOrDefault();
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
            Roles requestedUserHighestRole = GetUserRoles(requesterUserId).OrderBy(r => r.Priority).FirstOrDefault();
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
            OnlineUsers[] ons = GetAllOnlineUsers().Where(o => o.User == onlineUsers.User && o.UserDevice == onlineUsers.UserDevice).ToArray<OnlineUsers>();
            foreach (OnlineUsers item in ons)
            {
                item.IsDeleted = true;
                _onlineRepo.Update(item);
                //_onlineRepo.Delete(item);
            }
            //_onlineRepo.RemoveOnlineUsersByUserDeviceAndUserID(onlineUsers.UserDevice, onlineUsers.User.Id);
            _onlineRepo.Add(onlineUsers);// .Save(onlineUsers);
            return true;
        }

        public void ClerarAllUserLogins(Guid userId)
        {
            List<OnlineUsers> ou = GetAllOnlineUsers().Where(o => o.User == userId).ToList<OnlineUsers>();
            for (int i = 0; i < ou.Count; i++)
            {
                ou[i].IsDeleted = true;
                _onlineRepo.Update(ou[i]);
            }
        }


        public List<OnlineUsers> GetAllOnlineUsers()
        {
            return _onlineRepo.GetAll().Where(o => o.IsDeleted == false).ToList<OnlineUsers>();
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
                    OnlineUsers _usr = GetAllOnlineUsers().Where(o => o.Guid == token && o.IsDeleted == false).FirstOrDefault(); //GetOnlineUserByGuid(token);
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

            return GetAllUsers().Where(u => u.Cellphone == cellphone).SingleOrDefault();
            //return _userRepo.GetAll().Where(u => u.Cellphone == cellphone).SingleOrDefault();
        }

        public Guid AddAvertise(Advertise advertise, Guid userId)
        {
            if (advertise.ViewQuota != -1)
            {
                advertise.RemainedViewQuota = advertise.ViewQuota;
            }


            return _adverticeRepo.Add(advertise).Id;
        }

        public List<Advertise> GetAllPermenantAdvertises()
        {
            return _adverticeRepo.GetAll().ToList<Advertise>();
        }


        public List<DTOAdvertise> GetAdvertises(Guid userID, bool beforeDate, int pageIndex, DateTime? afterThisDate = null)
        {
            // get current user
            Users user = _userRepo.GetById(userID);


            if (CachedContents.Advertises.Count == 0)
            {
                // get all ads if owner quota is not ended and ads is not expired
                List<Advertise> _result = _adverticeRepo.GetAll().Where(a => (a.RemainedViewQuota != -1 || a.RemainedViewQuota > 0) && a.Expiracy <= DateTime.Now && a.IsAvtivated && a.IsDeleted == false && a.IsRejected == false)
                    .Join(
                        _userRepo.GetAll().Where(u => u.IsActivated == true && u.IsDeleted == false).ToList<Users>(),
                        ads => ads.Owner,
                        users => users.Id,
                        (ads, users) => ads
                    //new Advertise { Id=ads.Id, Name=ads.Name, Owner=ads.Owner, Caption=ads.Caption, Created=ads.Created, CreatedBy=ads.CreatedBy, CreationDate=ads.CreationDate, Expiracy=ads.Expiracy, IsAvtivated=ads.IsAvtivated, IsDeleted=ads.IsDeleted, IsSpecial=ads.IsSpecial, IsVideo=ads.IsVideo, LastModified=ads.LastModified, LastModifiedBy=ads.LastModifiedBy, LikeReward=ads.LikeReward, MediaSourceURL=ads.MediaSourceURL, RemainedViewQuota=ads.RemainedViewQuota, ViewQuota=ads.ViewQuota, ViewReward=ads.ViewReward}
                    )
                    .OrderByDescending(l => l.CreationDate)
                    .ToList<Advertise>();
                CachedContents.Advertises = _result;
            }

            if (CachedContents.Likers.Count == 0)
            {
                CachedContents.Likers = _likersRepo.GetAll().Where(l => l.IsDeleted == false).ToList<Likers>();

            }
            if (CachedContents.Viewers.Count == 0)
            {
                CachedContents.Viewers = _viewersRepo.GetAll().Where(l => l.IsDeleted == false).ToList<Viewers>();

            }


            // create return data model object
            List<DTOAdvertise> dTOAdvertise = new List<DTOAdvertise>();

            List<Advertise> tmpAds = CachedContents.Advertises.Skip(pageIndex * 3).Take(3).ToList<Advertise>();
            if (afterThisDate != null)
            {
                if (beforeDate)
                {
                    tmpAds = CachedContents.Advertises.Where(a => a.CreationDate < afterThisDate).Skip(pageIndex * 3).Take(3).ToList<Advertise>();
                }
                else
                {
                    tmpAds = CachedContents.Advertises.Where(a => a.CreationDate > afterThisDate).Skip(pageIndex * 3).Take(3).ToList<Advertise>();
                }

            }

            // prepare returning ads
            //bool GoNext = false;
            for (int i = 0; i < tmpAds.Count; i++)
            {
                Advertise item = tmpAds[i];

                if (item.Owner != userID)
                {
                    if (CachedContents.Viewers.Where(v => v.Advertise == item.Id && v.ViewedBy == userID).ToList<Viewers>().Count == 0)
                    {
                        Viewers tmpView = _viewersRepo.Add(new Viewers { Advertise = item.Id, ViewedBy = userID, Created = DateTime.Now });
                        CachedContents.Viewers.Add(tmpView);
                    }

                }


                // prepare likers of current ad
                IList<Likers> _likers = CachedContents.Likers.Where(l => l.Advertise == item.Id).ToList<Likers>();
                IList<Viewers> _viewers = CachedContents.Viewers.Where(v => v.Advertise == item.Id).ToList<Viewers>();

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
                _dtoAds.YouLiked = (CachedContents.Likers.Where(l => l.Advertise == item.Id && l.LikedBy == userID).ToList<Likers>().Count == 0) ? false : true;

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
                .OrderByDescending(l => l.LastModified)
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
            //Advertise _tmp = CachedContents.Advertises.Where(u => u.Id == ads.Id).FirstOrDefault();
            //CachedContents.Advertises.Remove(_tmp);
            //CachedContents.Advertises.Add(ads);
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
                    Roles deleterRole = GetUserRoles(userId).OrderBy(r => r.Priority).FirstOrDefault();
                    // deleter is not owner but is deleter admin or super?
                    if (deleterRole.RoleName == "admin" || deleterRole.RoleName == "super")
                    {
                        // remove ads and set lastmodifier to admin or super which is deleting
                        ads.IsDeleted = true;
                        ads.LastModified = DateTime.Now;
                        ads.LastModifiedBy = userId.ToString();
                        UpdateAdvertisement(ads);
                        //_adverticeRepo.Update(ads);
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
                UpdateAdvertisement(ads);
                //_adverticeRepo.Update(ads);
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
            Likers result = _likersRepo.Add(new Likers { Advertise = advertiseID, LikedBy = userID });
            CachedContents.Likers.Add(result);
            return result;
        }

        public bool RemoveLikeFromAdvertise(Guid advertiseID, Guid UserID)
        {
            //Advertise ad = _adverticeRepo.GetById(advertiseID);
            //Users usr = _userRepo.GetById(UserID);
            Likers lk = _likersRepo.GetAll().Where(l => l.Advertise == advertiseID && l.LikedBy == UserID).FirstOrDefault();
            _likersRepo.Delete(lk);
            return true;
        }

        public DTOAdvertise WatchedAdvertiseByUserID(Guid advertiseID, Guid UserID)
        {
            // get liked ads
            Advertise _ad = GetAdvertise(advertiseID);
            if (_ad != null)
            {
                // check if current user watched the ads before or not
                List<Viewers> prevViewers = _viewersRepo.GetAll().Where(l => l.Advertise == advertiseID)// GetLikes(_ad)
                    .Where(l => l.ViewedBy == UserID)
                    .ToList<Viewers>();

                if (prevViewers.Count == 0)
                {
                    // get watcher user
                    Users _watcher = _userRepo.GetById(UserID);


                    // checks if ads quota is not unlimited and if current viewer is not the owner of ad
                    if (_ad.ViewQuota != -1 && UserID != _ad.Owner)
                    {
                        // then decrease remained view quota 1 unit
                        _ad.RemainedViewQuota -= 1;
                        //CachedContents.Advertises.Where(a => a.Id == item.Id).FirstOrDefault().RemainedViewQuota -= 1;
                        if (_ad.RemainedViewQuota < 0)
                        {
                            CachedContents.Advertises.Remove(_ad);

                        }
                        // add view
                        Viewers toCache = _viewersRepo.Add(new Viewers { Advertise = advertiseID, ViewedBy = UserID });
                        CachedContents.Viewers.Add(toCache);

                        // check if liker is not ads owner
                        if (_ad.Owner != UserID)
                        {
                            // then add ads like reward to liker
                            _watcher.Points += _ad.ViewReward;
                            _userRepo.Update(_watcher);
                        }
                        UpdateAdvertisement(_ad);

                    }

                }


                // prepare likers of current ad
                //IList<Likers> _likers = _likersRepo.GetAll().Where(l => l.Advertise == _ad.Id).ToList<Likers>();
                //IList<Viewers> _viewers = _viewersRepo.GetAll().Where(v => v.Advertise == _ad.Id).ToList<Viewers>();
                IList<Likers> _likers = CachedContents.Likers.Where(l => l.Advertise == _ad.Id).ToList<Likers>();
                IList<Viewers> _viewers = CachedContents.Viewers.Where(v => v.Advertise == _ad.Id).ToList<Viewers>();

                // map ad, likers and viewers to ad DTO
                DTOAdvertise _dtoAds = new DTOAdvertise();

                _dtoAds = _mapper.Map<DTOAdvertise>(_ad);

                _dtoAds.AdvertiseID = _ad.Id;
                //_dtoAds.Caption = item.Caption;
                //_dtoAds.Name = item.Name;
                _dtoAds.CreationDate = _ad.CreationDate.ToString();
                _dtoAds.Likers = _likers;
                _dtoAds.MediaSourceURL = _ad.MediaSourceURL;
                _dtoAds.Owner = _mapper.Map<DTOUser>(GetUser(_ad.Owner));
                _dtoAds.Viewers = _viewers;
                _dtoAds.IsVideo = _ad.IsVideo;
                _dtoAds.LikerCount = _likers.Count;
                _dtoAds.ViewerCount = _viewers.Count;
                _dtoAds.LikeReward = _ad.LikeReward;
                _dtoAds.ViewReward = _ad.ViewReward;
                _dtoAds.YouLiked = (CachedContents.Likers.Where(l => l.Advertise == _ad.Id && l.LikedBy == UserID).ToList<Likers>().Count == 0) ? false : true;

                return _dtoAds;

            }



            return null;
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
                    Likers toCache = _likersRepo.Add(new Likers { Advertise = advertiseID, LikedBy = UserID });
                    CachedContents.Likers.Add(toCache);

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

        bool IUserServices.LogOut(Guid UserID, string GUID, bool killLogout = false)
        {
            if (killLogout)
            {
                ClerarAllUserLogins(UserID);
                return true;
            }

            OnlineUsers[] onlines = GetAllOnlineUsers().Where(o => o.User == UserID && o.Guid == GUID).ToArray<OnlineUsers>();
            foreach (OnlineUsers item in onlines)
            {
                item.IsDeleted = true;
                _onlineRepo.Update(item);
                //_onlineRepo.Delete(item);
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
                .OrderByDescending(d => d.StartDate)
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

        public List<DTODraws> GetAllActiveNotArchivedDrawsByUser(Guid userId)
        {
            // get all ads if owner quota is not ended and ads is not expired
            List<Draws> result = _drawsRepo.GetAll()
                .Join(
                    _userRepo.GetAll().Where(u => u.IsActivated == true && u.IsDeleted == false).ToList<Users>(),
                    draws => draws.Owner,
                    users => users.Id,
                    (draws, users) => draws
                )
                .Where(d => d.IsActivated == true && d.IsDeleted == false && d.IsArchived == false)
                .OrderByDescending(d => d.StartDate)
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
        public bool UpdateConstantDictionary(ConstantDictionaries constantDictionary)
        {
            _constRepo.Update(constantDictionary);
            return true;
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
        public bool removeDonnationTicket(Guid donnationId, Guid userId)
        {
            DonnationTickets _ticket = _donnationTicketRepo.GetById(donnationId);
            if (_ticket != null)
            {
                if (_ticket.Donner == userId)
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
            Draws _currentDraw = _drawsRepo.GetById(drawId);

            int prizesWinnersCount = 0;
            foreach (Prizes item in prizes)
            {
                prizesWinnersCount += item.WinnerCount;
            }

            List<Users> winners = GetAllUsers().OrderByDescending(u => u.Points).ToList<Users>();

            int indx = 0;


            do
            {
                foreach (Prizes item in prizes)
                {
                    if (indx == winners.Count - 1)
                    {
                        break;
                    }
                    for (int j = 0; j < item.WinnerCount; j++)
                    {
                        if (indx == winners.Count - 1)
                        {
                            break;
                        }
                        PrizesWinners _pw = new PrizesWinners { Prize = item.Id, User = winners[indx].Id, WiningPoint = winners[indx].Points, WiningDate = DateTime.Now, Draw = drawId };
                        _prizeWinnersRepo.Add(_pw);

                        long wonMoney = 0;
                        if (item.ValueInMoney != null)
                        {
                            wonMoney = Convert.ToInt64(item.ValueInMoney);
                            winners[indx].Money += wonMoney;
                            _userRepo.Update(winners[indx]);
                        }
                        _transactionPercentsRepository.Add(new TransactionPercents
                        {
                            Created = DateTime.Now,
                            Description = "جایزه " + item.Name,
                            ReferenceID = "برنده رتبه " + indx.ToString() + " در دوره " + _currentDraw.Name,
                            FromAmount = wonMoney,
                            ToAmount = wonMoney,
                            FromUser = _currentDraw.Owner,
                            ToUser = winners[indx].Id,
                            Percentage = 0,
                            Transaction = item.Id
                        });

                        indx += 1;
                    }
                }
                if (indx == winners.Count - 1)
                {
                    break;
                }
            } while (indx < prizesWinnersCount);

            _userRepo.GetAll().ToList().ForEach(u => u.Points = 0);
            return true;
        }

        public List<Transactions> GetAllTransactions()
        {
            return _transactionsRepo.GetAll().Where(t => t.IsDeleted == false).ToList<Transactions>();
        }

        public List<Transactions> GetTransactionsByUser(Guid userId)
        {
            return GetAllTransactions().Where(t => t.User == userId).ToList<Transactions>();
        }

        public Guid AddTransaction(Transactions transaction)
        {
            _transactionsRepo.Add(transaction);
            return transaction.Id;
        }

        public bool UpdateTransaction(Transactions transaction)
        {
            _transactionsRepo.Update(transaction);
            return true;
        }

        public Guid AddPurchaseCredit(Purchases purchase)
        {
            _purchasesRepository.Add(purchase);
            return purchase.Id;

        }

        public bool AddTransactionPercent(TransactionPercents transactionPercent)
        {
            _transactionPercentsRepository.Add(transactionPercent);
            return true;
        }

        public List<TransactionPercents> GetAllTransactionPercents()
        {
            return _transactionPercentsRepository.GetAll().Where(tp => tp.IsDeleted == false).ToList<TransactionPercents>();
        }

        public List<Chips> GetAllChips()
        {
            return _chipsRepo.GetAll().Where(c => c.IsDeleted == false).ToList<Chips>();
        }

        public void AddChips(Chips chips)
        {
            _chipsRepo.Add(chips);
        }

        public void UpdateChips(Chips chips)
        {
            _chipsRepo.Update(chips);
        }

        public void RemoveChips(Chips chips)
        {
            chips.IsDeleted = true;
            UpdateChips(chips);
        }
    }
}
