using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class UsersRoles : AuditableBaseEntity
    {
        public Guid User { get; set; }
        public Guid Role { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
