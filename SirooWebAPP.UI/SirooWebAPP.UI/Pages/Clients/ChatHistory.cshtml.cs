using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class ChatHistoryModel : PageModel
    {

        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public ChatHistoryModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


        }


        public List<ChatConversationsModel> ChatConversation { get; set; }

        public bool ConversationPage { get; set; }
        public string ToUsername { get; set; }
        public bool ChatSelf { get; set; }

        public List<ChatMessages> conversationMessages { get; set; }
        public Guid MyGuid { get; set; }
        public bool IsNewChat { get; set; }

        public Guid ToUserId { get; set; }

        public bool IsBlockedByYou { get; set; }

        public string ToUserProfileImage { get; set; }


        public void OnGet()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);
            if (theUser.HasNewMessage==true)
            {
                theUser.HasNewMessage=false;
                _usersServices.UpdateUser(theUser);
            }

            if (Request.Query["touser"].Count == 0)
            {
                InitiateChats();
            }
            else
            {
                string _touser = Request.Query["touser"];
                Guid _touserId = Guid.Empty;
                Users touser = new Users();
                try
                {
                    _touserId = Guid.Parse(_touser);
                    touser = _usersServices.GetUser(Guid.Parse(_touser));
                }
                catch (Exception)
                {
                    touser = _usersServices.GetUserByUsername(_touser);
                }


                MyGuid = theUser.Id;

                if (touser != null)
                {
                    if (touser.Id == theUser.Id)
                    {
                        ChatSelf = true;
                        InitiateChats();
                        return;
                    }
                }
                else
                {
                    IsNewChat = true;
                }




                if (touser != null && theUser != null)
                {
                    ConversationPage = true;
                    conversationMessages = new List<ChatMessages>();
                    ToUsername = touser.Username;
                    conversationMessages = _usersServices.GetAllChatMessages().Where(c => (c.ToUser == touser.Id && c.FromUser == theUser.Id) || (c.ToUser == theUser.Id && c.FromUser == touser.Id)).OrderByDescending(c => c.Created).Take(500).ToList<ChatMessages>();
                    conversationMessages = conversationMessages.OrderBy(c => c.Created).ToList<ChatMessages>();
                    ToUserProfileImage = touser.ProfileMediaURL;

                    List<ChatMessages> _allUnreadChats = _usersServices.GetAllChatMessages().Where(cm => cm.ToUser == theUser.Id && cm.FromUser == touser.Id && cm.IsRead == false).ToList<ChatMessages>();
                    if (_allUnreadChats.Count > 0)
                    {
                        foreach (ChatMessages item in _allUnreadChats)
                        {
                            item.IsRead = true;
                            _usersServices.UpdateChatMessage(item);
                        }
                    }

                    if (_usersServices.GetAllChatBlocks().Where(cb=>cb.fromUser==theUser.Id && cb.toUser==touser.Id).FirstOrDefault()!=null)
                    {
                        IsBlockedByYou = true;
                    }
                    else
                    {
                        IsBlockedByYou = false;
                    }
                }
            }



        }

        private void InitiateChats()
        {
            // get current user
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users theUser = _usersServices.GetUser(creatorID);

            ChatConversation = new List<ChatConversationsModel>();

            if (theUser != null)
            {
                var items = _usersServices.GetAllChatMessages().Where(c => c.FromUser == theUser.Id).OrderByDescending(c => c.Created).GroupBy(g => g.ToUser).Take(500);
                var items2 = _usersServices.GetAllChatMessages().Where(c => c.ToUser == theUser.Id).OrderByDescending(c => c.Created).GroupBy(g => g.FromUser).Take(500);




                //var CustomerGroup = from T in _usersServices.GetAllChatMessages().Where(c => c.FromUser == theUser.Id)
                //                    orderby T.Created descending
                //                    group T by T.ToUser;

                foreach (var item in items)
                {
                    Users tmpusr = _usersServices.GetUser(item.Key);
                    ChatConversation.Add(new ChatConversationsModel
                    {
                        HasUnread = _usersServices.GetAllChatMessages().Where(c => c.ToUser == theUser.Id && c.FromUser == item.Key && c.IsRead == false).ToList<ChatMessages>().Count,
                        LastMessage = DateTime.Now,
                        UserID = item.Key,
                        Username = tmpusr.Username,
                        ProfileImage=tmpusr.ProfileMediaURL
                    });
                }
                foreach (var item in items2)
                {
                    if (ChatConversation.Where(c => c.UserID == item.Key).ToList<ChatConversationsModel>().Count > 0)
                    {
                        continue;
                    }
                    Users tmpusr = _usersServices.GetUser(item.Key);
                    ChatConversation.Add(new ChatConversationsModel
                    {
                        HasUnread = _usersServices.GetAllChatMessages().Where(c => c.ToUser == theUser.Id && c.FromUser == item.Key && c.IsRead == false).ToList<ChatMessages>().Count,
                        LastMessage = DateTime.Now,
                        UserID = item.Key,
                        Username = tmpusr.Username,
                        ProfileImage= tmpusr.ProfileMediaURL
                    });
                }

                ChatConversation.OrderByDescending(c => c.LastMessage).ToList<ChatConversationsModel>();

            }

        }
    }
}
