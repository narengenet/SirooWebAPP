using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class TicketsModel
    {
        public string QRsrc { get; set; }
        public string TicketURL { get; set; }
        public long Val { get; set; }
        public int Capacity { get; set; }
    }
}
