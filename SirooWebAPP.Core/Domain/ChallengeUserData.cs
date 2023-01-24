using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class ChallengeUserData : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public Guid Graph { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FatherName { get; set; }
        public string NationalID { get; set; }
        public string IdentityID { get; set; }
        public string BirthDate { get; set; }
        public string Cellphone { get; set; }
        public bool IsMarried { get; set; }



    }
}
