using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Prizes : AuditableBaseEntity
    {
        public string Name { get; set; }
        public Draws Draw { get; set; }
        public int WinnerCount { get; set; }
        public int Priority { get; set; }
        public Users CreatedBy { get; set; }
        public bool IsActivated { get; set; }

    }
}
