using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class InsuranceSecondUserData : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalID { get; set; }
        public string IdentityID { get; set; }
        public string FatherName { get; set; }
        public string Cellphone { get; set; }
        public string AddressProvience { get; set; }
        public string AddressCity { get; set; }
        public string AddressDetails { get; set; }
        public string AddressPostalCode { get; set; }
        public string NationalIDPerson { get; set; }
        public string FullNamePerson { get; set; }
        public bool ThePolicy { get; set; }

        public bool IsPaid { get; set; }
        public string? Username { get; set; }
        public bool? IsExported { get; set; }

        public Guid TheParent { get; set; }

    }
}

