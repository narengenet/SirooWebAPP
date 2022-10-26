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
        public long Credits { get; set; }
        public long Money { get; set; }
        public long DefaultCredit { get; set; }
        public bool DonnationActive { get; set; }
        public string? ProfileMediaURL { get; set; }
        public Guid? Inviter { get; set; }

        public string FullName()
        {
            return Name + " " + Family;
        }

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
