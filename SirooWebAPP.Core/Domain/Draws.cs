using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Draws : AuditableBaseEntity
    {

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsLottery { get; set; }
        public Users CreatedBy { get; set; }
        public bool IsActivated { get; set; }
    }
}
