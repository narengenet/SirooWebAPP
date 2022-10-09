using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class PrizesWinners : AuditableBaseEntity
    {
        public Guid Prize { get; set; }
        public Guid User { get; set; }
        public long WiningPoint { get; set; }
        public DateTime WiningDate { get; set; }
    }
}
