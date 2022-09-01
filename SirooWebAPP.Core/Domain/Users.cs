using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Users
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string? Username { get; set; }
        public string? Cellphone { get; set; }
        public virtual Users? Inviter { get; set; }
        public virtual Users[]? Inviteds { get; set; }


    }
}
