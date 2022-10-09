using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain.Base
{
    public abstract class AuditableBaseEntity : BaseEntity
    {
        public virtual DateTime? Created { get; set; }
        public virtual string? LastModifiedBy { get; set; }
        public virtual DateTime? LastModified { get; set; }
        public virtual bool IsDeleted{ get; set; }
    }
}
