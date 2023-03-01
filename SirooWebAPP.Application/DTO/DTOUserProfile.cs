using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.DTO
{
    public class DTOUserProfile
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Username { get; set; }
        //public string Cellphone { get; set; }
        public bool IsActivated { get; set; }
        //public string? ConfirmationCode { get; set; }
        public long Points { get; set; }
        //public long Credits { get; set; }
        public string? ProfileMediaURL { get; set; }
        public string? InviterUsername { get; set; }
        public List<DTOUserProfile> Inviteds { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public long Credits { get; set; }
        public DateTime CreationDate { get; set; }
        public string RoleName { get; set; }
        public bool? ShowMyFullNameInPublic { get; set; }
    }
}
