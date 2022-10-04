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
        public Users User { get; set; }
        public Roles Role { get; set; }
        public Users CreatedBy { get; set; }
    }
}
