using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Graphs : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public Guid? Parent { get; set; }
        public Guid? GrandParent { get; set; }
        public bool IsFirstChildOfParent { get; set; }
        public int DirectChildCount { get; set; }
        public bool IsExpired { get; set; }
        public DateTime ExpireDate { get; set; }
        public int ReceivedShared{ get; set; }

    }
}
