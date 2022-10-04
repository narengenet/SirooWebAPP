using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Viewers : AuditableBaseEntity
    {
        public Guid ViewedBy { get; set; }
        public Guid Advertise { get; set; }
    }
}
