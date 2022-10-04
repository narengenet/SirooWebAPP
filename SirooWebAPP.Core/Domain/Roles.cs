using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Roles : AuditableBaseEntity
    {

        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsActivated { get; set; }
    }
}
