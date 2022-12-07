namespace SirooWebAPP.UI.ViewModels
{
    public class RequestMoneyUser
    {
        public string UserName { get; set; }
        public Guid RequestID { get; set; }
        public long RequestMoney { get; set; }
        public string PhoneNumber { get; set; }
        public string CardNumber { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }
    }
}
