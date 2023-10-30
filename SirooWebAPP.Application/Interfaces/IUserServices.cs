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
        List<Users> GetNotDeletedUsers();
        Users GetUserByUsername(string username);
        Users GetUserByCellphone(string cellphone);
        List<Users> GetUsers(int pageNumber);
        DTOUserProfile GetUserProfile(Guid userId);
        List<Users> GetAllUsers();
        List<Users> GetAllUsersEvenDeleted();
        List<Users> GetAllDeletedUsers();
        List<DTOUserSmall> GetAllLesserPriorityUsers(Guid requesterUserId);

        List<string> GetCellphones();
        Guid AddUser(Users usr);
        bool RemovePermUser(Users user);
        bool UpdateUser(Users user);
        public bool RegisterdSuccessfullyAndLogin(OnlineUsers onlineUsers);
        public bool LoginSuccessfully(OnlineUsers onlineUsers);
        bool CheckUserLogin(Guid userId, string token);
        void ClerarAllUserLogins(Guid userId);
        List<OnlineUsers> GetAllOnlineUsers();



        public Guid AddAvertise(Advertise advertise, Guid userId);
        public List<Advertise> GetAllPermenantAdvertises();
        public List<DTOAdvertise> GetAdvertises(Guid userID, bool beforeDate, int pageIndex, DateTime? afterThisDate, string? username);
        public List<DTOAdvertise> GetMyAdvertises(Guid userID, int page);
        public List<DTOAdvertise> GetPendingAdvertises(Guid userID, int page);
        public bool UpdateAdvertisement(Advertise ads);
        public Advertise GetAdvertise(Guid adsID);
        //string GetInviterUsername(int ID);
        public Likers AddLikeToAdvertise(Guid advertiseID, Guid userID);
        public bool RemoveLikeFromAdvertise(Guid advertiseID, Guid UserID);
        int DoLikeAdvertiseByUserID(Guid advertiseID, Guid UserID);
        DTOAdvertise WatchedAdvertiseByUserID(Guid advertiseID, Guid UserID);
        bool DeleteAdvertise(Guid postID, Guid userId);
        bool LogOut(Guid UserID, string GUID, bool killLogout = false);

        Roles AddRole(Roles roles);
        Roles GetRole(Guid roleId);
        List<Roles> GetAllRoles();
        List<Roles> GetUserRoles(Guid userId);
        List<UsersRoles> GetAllPermenantUserRoles(Guid userId);
        Roles GetRoleByName(string Name);
        List<UsersRoles> GetAllUsersRoles();
        void UpdateUserRole(UsersRoles usersRoles);
        UsersRoles AddUserToRole(UsersRoles userRole);
        bool RemoveUserFromRole(UsersRoles userRole, Guid removedBy);

        List<Draws> GetAllDraws();
        List<DTODraws> GetAllActiveDrawsByUser(Guid userId);
        List<DTODraws> GetAllActiveNotArchivedDrawsByUser(Guid userId);
        Draws AddDraw(Draws draw);
        bool UpdateDraw(Draws draw);

        List<Prizes> GetAllPrizes();
        public List<Prizes> GetPrizesByDraw(Guid drawId);
        Prizes AddPrize(Prizes prize);
        bool UpdatePrize(Prizes prize);
        bool RemovePrize(Prizes prize, Guid removedBy);


        List<ConstantDictionaries> GetAllConstantDictionaries();
        ConstantDictionaries GetConstantDictionary(string key);
        bool UpdateConstantDictionary(ConstantDictionaries constantDictionary);


        List<PointUsages> GetAllPointUsages();
        List<PointUsages> GetAllUsedPointByDonner(Guid donnerId);
        bool UsePoint(Guid donnationTicketId, Guid donnerId, Guid receiverId, long point, bool isCredit);


        List<DonnationTickets> GetAllDonnationTickets();
        DonnationTickets GetDonnationTicket(Guid ticketId);
        Guid AddDonnationTicket(DonnationTickets donnationTicket);
        bool UpdateDonnationTicket(DonnationTickets donnationTicket);
        bool removeDonnationTicket(Guid donnationId, Guid userId);

        List<DTOUser> GetAllPrizeWinnersByDrawId(Guid drawId);
        bool AddPrizeWinner(Guid drawId);



        List<Transactions> GetAllTransactions();
        List<Transactions> GetTransactionsByUser(Guid userId);
        Guid AddTransaction(Transactions transaction);
        bool UpdateTransaction(Transactions transaction);
        Guid AddPurchaseCredit(Purchases purchase);


        bool AddTransactionPercent(TransactionPercents transactionPercent);
        List<TransactionPercents> GetAllTransactionPercents();


        List<Chips> GetAllChips();
        void AddChips(Chips chips);
        void UpdateChips(Chips chips);
        void RemoveChips(Chips chips);


        List<Contacts> GetAllContacts();
        void AddContacts(Contacts contacts);
        void RemoveContacts(Contacts contacts);
        bool UpdateContacts(Contacts contacts);


        List<DiamondUsages> GetAllDiamondUsages();
        void AddDiamondUsage(DiamondUsages diamondUsage);



        List<Graphs> GetAllGraphs();
        void AddGraph(Graphs graph);
        void UpdateGraph(Graphs graph);



        List<ChallengeUserData> GetAllChallengeUserData();
        void AddChallengeUserData(ChallengeUserData challengeUserData);
        void UpdateChallengeUserData(ChallengeUserData challengeUserData);


        List<GraphHistory> GetAllGraphHistoryData();
        void AddGraphHistory(GraphHistory graphHistory);




        List<ChatMessages> GetAllChatMessages();
        void AddChatMessages(ChatMessages chatMessages);
        void UpdateChatMessage(ChatMessages chatMessage);


        List<ChatBlocks> GetAllChatBlocks();
        List<ChatBlocks> GetAllChatBlocksWithDeleteds();

        void AddChatBlocks(ChatBlocks chatBlock);
        void UpdateChatBlocks(ChatBlocks chatBlock);


        List<Followers> GetAllFollowers(bool forceAll = false);
        void AddFollower(Followers follower);
        void UpdateFollower(Followers followers);

        List<InsuranceUserData> GetAllInsuranceUserData();
        void AddInsuranceUserData(InsuranceUserData insuranceUserData);
        void UpdateInsuranceUserData(InsuranceUserData insuranceUserData);

        List<InsuranceSecondUserData> GetAllInsuranceSecondUserData();
        void AddInsuranceSecondUserData(InsuranceSecondUserData insuranceUserData);
        void UpdateInsuranceSecondUserData(InsuranceSecondUserData insuranceUserData);

        List<InsuranceThirdUserData> GetAllInsuranceThirdUserData();
        void AddInsuranceThirdUserData(InsuranceThirdUserData insuranceUserData);
        void UpdateInsuranceThirdUserData(InsuranceThirdUserData insuranceUserData);



        List<InsuranceFourthUserData> GetAllInsuranceFourthUserData();
        void AddInsuranceFourthUserData(InsuranceFourthUserData insuranceUserData);
        void UpdateInsuranceFourthUserData(InsuranceFourthUserData insuranceUserData);

    }
}
