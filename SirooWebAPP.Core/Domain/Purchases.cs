using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Purchases : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public long PurchasedCredit { get; set; }
        public long MoneyPaied { get; set; }
    }
}
