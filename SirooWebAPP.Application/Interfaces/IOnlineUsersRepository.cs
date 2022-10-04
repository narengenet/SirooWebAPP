using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.Interfaces
{
    public interface IOnlineUsersRepository : IGenericRepository<OnlineUsers>
    {
        //public List<OnlineUsers> GetAllOnlineUsers();
        //public OnlineUsers GetOnlineUser(Guid id);
        //public OnlineUsers GetOnlineUserByGuid(string guid);
        //public List<OnlineUsers> GetOnlineUsersByUserId(Guid id);
        //public List<OnlineUsers> GetOnlineUsers(int pageNumber = 1);

        ///// <summary>
        ///// Remove any online record from current user's device or current browser of his/her device
        ///// </summary>
        ///// <param name="userDevice"></param>
        ///// <param name="userId">user id</param>
        ///// <returns>bool</returns>
        //public bool RemoveOnlineUsersByUserDeviceAndUserID(string userDevice, Guid userId);
        //public bool RemoveOnlineUsersByUseridAndToken(Guid userId,string guid);
        //public Guid? Save(OnlineUsers user);
        //public bool Update(OnlineUsers user);
    }
}
