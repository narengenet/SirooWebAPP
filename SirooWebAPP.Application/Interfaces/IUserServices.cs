using SirooWebAPP.Core.Domain;
using SirooWebAPP.Application.DTO;
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
        Users GetNotDeletedUser(Guid id);
        Users GetUserByUsername(string username);
        Users GetUserByCellphone(string cellphone);
        List<Users> GetUsers(int pageNumber);
        List<Users> GetAllUsers();
        List<DTOUserSmall> GetAllLesserPriorityUsers(Guid requesterUserId);

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
        Roles GetRole(Guid roleId);
        List<Roles> GetAllRoles();
        List<Roles> GetUserRoles(Guid userId);
        Roles GetRoleByName(string Name);
        List<UsersRoles> GetAllUsersRoles();
        void UpdateUserRole(UsersRoles usersRoles);
        UsersRoles AddUserToRole(UsersRoles userRole);
        bool RemoveUserFromRole(UsersRoles userRole,Guid removedBy);

        List<Draws> GetAllDraws();
        List<DTODraws> GetAllActiveDrawsByUser(Guid userId);
        Draws AddDraw(Draws draw);
        bool UpdateDraw(Draws draw);
        
        List<Prizes> GetAllPrizes();
        public List<Prizes> GetPrizesByDraw(Guid drawId);
        Prizes AddPrize(Prizes prize);
        bool UpdatePrize(Prizes prize);
        bool RemovePrize(Prizes prize, Guid removedBy);


        List<ConstantDictionaries> GetAllConstantDictionaries();
        ConstantDictionaries GetConstantDictionary(string key);


        List<PointUsages> GetAllPointUsages();
        List<PointUsages> GetAllUsedPointByDonner(Guid donnerId);
        bool UsePoint(Guid donnationTicketId, Guid donnerId, Guid receiverId, long point, bool isCredit);


        List<DonnationTickets> GetAllDonnationTickets();
        DonnationTickets GetDonnationTicket(Guid ticketId);
        bool UpdateDonnationTicket(DonnationTickets donnationTicket);

    }
}
