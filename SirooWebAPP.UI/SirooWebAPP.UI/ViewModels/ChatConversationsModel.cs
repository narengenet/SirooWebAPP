namespace SirooWebAPP.UI.ViewModels
{
    public class ChatConversationsModel
    {
        public string Username { get; set; }
        public Guid UserID { get; set; }
        public DateTime LastMessage { get; set; }
        public bool HasUnread { get; set; }

    }
}
