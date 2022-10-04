using SirooWebAPP.Core.Domain;
using SirooWebAPP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.Interfaces
{
    public interface IUserServices
    {
        public static bool IsLoggedIn = false;

        List<String> GetUsernames();
        Users GetUser(Guid id);
        Users GetUserByUsername(string username);
        Users GetUserByCellphone(string cellphone);
        List<Users> GetUsers(int pageNumber);
        List<Users> GetAllUsers();

        List<string> GetCellphones();
        Guid AddUser(Users usr);
        bool UpdateUser(Users user);
        public bool RegisterdSuccessfullyAndLogin(OnlineUsers onlineUsers);
        public bool LoginSuccessfully(OnlineUsers onlineUsers);
        bool CheckUserLogin(Guid userId, string token);
        public Guid AddAvertise(Advertise advertise,Guid userId);
        public List<DTOAdvertise> GetAdvertises(Guid userID);
        //string GetInviterUsername(int ID);
        public Likers AddLikeToAdvertise(Guid advertiseID, Guid userID);
        public bool RemoveLikeFromAdvertise(Guid advertiseID, Guid UserID);
        bool DoLikeAdvertiseByUserID(Guid advertiseID, Guid UserID);
        bool LogOut(Guid UserID,string GUID);
        Roles AddRole(Roles roles);

    }
}
