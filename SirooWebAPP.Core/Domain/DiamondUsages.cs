using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class DiamondUsages : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public int DiamondsWon { get; set; }
        public int? PointCharged { get; set; }
    }
}
