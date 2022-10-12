using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class RoleChangeRequests : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public Guid ToRole { get; set; }
        public Guid CreatedBy { get; set; }
        public bool IsAccepted { get; set; }
    }
}
