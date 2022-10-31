using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class TransactionPercents : AuditableBaseEntity
    {
        public Guid Transaction { get; set; }
        public string? ReferenceID { get; set; }
        public Guid FromUser { get; set; }
        public Guid ToUser { get; set; }
        public long FromAmount { get; set; }
        public long ToAmount { get; set; }
        public int Percentage { get; set; }
        public string Description { get; set; }
    }
}
