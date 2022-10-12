using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class PointUsages : AuditableBaseEntity
    {
        public Guid Donner { get; set; }
        public Guid Receiver { get; set; }
        public bool IsUsed { get; set; }
        public long Value { get; set; }
        public bool IsCredit { get; set; }
    }
}
