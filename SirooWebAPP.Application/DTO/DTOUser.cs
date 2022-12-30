using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.DTO
{
    public class DTOUser
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Username { get; set; }
        //public string Cellphone { get; set; }
        public bool IsActivated { get; set; }
        //public string? ConfirmationCode { get; set; }
        public long Points { get; set; }
        public long Diamonds { get; set; }
        //public long Credits { get; set; }
        public string? ProfileMediaURL { get; set; }
        public string? InviterUsername { get; set; }
        public List<string> Inviteds { get; set; }
        //public virtual Users? Inviter { get; set; }
        //public ICollection<Users>? Inviteds { get; set; }
    }
}
