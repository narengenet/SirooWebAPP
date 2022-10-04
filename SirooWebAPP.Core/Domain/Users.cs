using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Users : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Username { get; set; }
        public string Cellphone { get; set; }
        public bool IsActivated { get; set; }
        public string? ConfirmationCode { get; set; }
        public long Points { get; set; }
        public string? ProfileMediaURL { get; set; }
        public virtual Users? Inviter { get; set; }
        public ICollection<Users>? Inviteds { get; set; }

    }
    //public class Users
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string Family { get; set; }
    //    public string Username { get; set; }
    //    public string Cellphone { get; set; }
    //    public bool IsActivated { get; set; }
    //    public string? ConfirmationCode { get; set; }
    //    public long Points { get; set; }
    //    public string? ProfileMediaURL { get; set; }
    //    public virtual Users? Inviter { get; set; }
    //    public ICollection<Users>? Inviteds { get; set; }

    //    public Users()
    //    {

    //    }


    //}
}
