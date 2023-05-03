using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class InsuranceUserData : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalID { get; set; }
        public string IdentityID { get; set; }
        public string BirthDate { get; set; }
        public string FatherName { get; set; }
        public string IssuePlace { get; set; }
        public bool Gender { get; set; }
        public bool IsMarried { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string MilitaryServiceStatus { get; set; }
        public string ResidentialPhone { get; set; }
        public string Cellphone { get; set; }
        public string JobTitle { get; set; }
        public string AddressProvience { get; set; }
        public string AddressCity { get; set; }
        public string AddressDetails { get; set; }
        public string AddressPostalCode { get; set; }
        public bool FatherIsAlive { get; set; }
        public bool MotherIsAlive { get; set; }

        public bool IsPaid { get; set; }
        public string? Username { get; set; }
        public bool? IsExported { get; set; }

        public Guid TheParent { get; set; }

    }
}

