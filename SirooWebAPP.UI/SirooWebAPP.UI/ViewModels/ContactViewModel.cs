namespace SirooWebAPP.UI.ViewModels
{
    public class ContactViewModel
    {
        public Guid Id { get; set; }
        public Guid FromUser { get; set; }
        public string Username { get; set; }
        public string TheMessage { get; set; }
        public bool IsRead { get; set; }
        public string? ReplyMessage { get; set; }
        public bool IsReplied { get; set; }
        public DateTime? ReadDate { get; set; }
        public DateTime? ReplyDate { get; set; }
        public DateTime? Created { get; set; }
    }
}
