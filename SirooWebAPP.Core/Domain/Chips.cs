using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Chips : AuditableBaseEntity
    {
        public int Points { get; set; }
        public Guid UsedBy { get; set; }
        
        public string PIN { get; set; }
        
        public long SerialNumber { get; set; }
        public bool IsUsed { get; set; }
        

    }
}
