using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class ChatBlocks : AuditableBaseEntity
    {
        public Guid FromUser { get; set; }
        public Guid ToUser { get; set; }

    }
}

