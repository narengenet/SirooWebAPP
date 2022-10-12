using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class ConstantDictionaries : AuditableBaseEntity
    {
        public string ConstantKey { get; set; }
        public string ConstantValue { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
