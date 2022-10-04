    using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Contexts;
using SirooWebAPP.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Infrastructure.Repositories
{
    public class OnlineUsersRepository : GenericRepository<OnlineUsers>, IOnlineUsersRepository
    {
        public OnlineUsersRepository(AppDbContext dbContext) : base(dbContext)
        {


        }

        //private readonly AppDbContext _context;
        //List<OnlineUsers> _onlineUsers;

        //public OnlineUsersRepository(AppDbContext context)
        //{
        //    _context = context;
        //    _onlineUsers = context.OnlineUsers.ToList<OnlineUsers>();
        //}
        ////public OnlineUsersRepository()
        ////{

        ////}

        //public List<OnlineUsers> GetAllOnlineUsers()
        //{
        //    throw new NotImplementedException();
        //}

        //public OnlineUsers GetOnlineUser(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public OnlineUsers GetOnlineUserByGuid(string guid)
        //{
        //    return _onlineUsers.FirstOrDefault(u => u.Guid == guid);
        //}

        //public List<OnlineUsers> GetOnlineUsers(int pageNumber = 1)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<OnlineUsers> GetOnlineUsersByUserId(Guid id)
        //{
        //    return _onlineUsers.Where(u => u.User.Id == id).ToList<OnlineUsers>();
        //}


        //public bool RemoveOnlineUsersByUserDeviceAndUserID(string userDevice,Guid userId)
        //{
        //    // get all online records of the user with provided device info and user id
        //    List<OnlineUsers> _tmpOnlineUsers= _onlineUsers.FindAll(u => u.User.Id == userId && u.UserDevice==userDevice);
        //    // remove all online records with current device or current browser of his/her device
        //    foreach (OnlineUsers item in _tmpOnlineUsers)
        //    {
        //        _context.OnlineUsers.Remove(item);
        //    }
        //    _context.SaveChanges();
        //    return true;
        //}
        //public Guid? Save(OnlineUsers user)
        //{
        //    var result = _onlineUsers.Where(u => u.Id == user.Id);
        //    if (result != null)
        //    {
        //        if (result.Count() == 0)
        //        {
        //            //_users.Add(user);
        //            _context.OnlineUsers.Add(user);
        //            _context.SaveChanges();
        //            return user.User.Id;
        //        }
        //    }
        //    return null;
        //}

        //public bool Update(OnlineUsers user)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IOnlineUsersRepository.RemoveOnlineUsersByUseridAndToken(Guid userId, string guid)
        //{
        //    // get all online records of the user with provided guid and user id
        //    List<OnlineUsers> _tmpOnlineUsers = _onlineUsers.FindAll(u => u.User.Id == userId && u.Guid == guid);
        //    // remove all online records with current guid and userid
        //    foreach (OnlineUsers item in _tmpOnlineUsers)
        //    {
        //        _context.OnlineUsers.Remove(item);
        //    }
        //    _context.SaveChanges();
        //    return true;
        //}


    }
}
