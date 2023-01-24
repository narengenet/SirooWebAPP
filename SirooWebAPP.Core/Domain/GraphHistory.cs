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
    public class GraphHistory : AuditableBaseEntity
    {
        public Guid Graph { get; set; }
        public Guid User { get; set; }
        public Guid ToUser{ get; set; }

    }
}
