using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class Followers : AuditableBaseEntity
    {
        public Guid FollowPerson { get; set; }
        public Guid FollowedPerson { get; set; }


    }
}
