using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Transactions : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public string? ReferenceID { get; set; }
        public string? Status { get; set; }
        public bool IsSuccessfull { get; set; }

        public long Amount { get; set; }

    }
}
