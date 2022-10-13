using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class DonnationTickets : AuditableBaseEntity
    {
        public Guid Donner { get; set; }
        public long Value { get; set; }
        public int RemainedCapacity { get; set; }
        public bool IsCredit { get; set; }
    }
}
