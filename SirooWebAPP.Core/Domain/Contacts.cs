using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Contacts :AuditableBaseEntity
    {
        public Guid FromUser { get; set; }
        public string TheMessage { get; set; }
        public bool IsRead { get; set; }
        public string? ReplyMessage { get; set; }
        public bool IsReplied { get; set; }
        public DateTime? ReadDate { get; set; }
        public DateTime? ReplyDate { get; set; }

    }
}
