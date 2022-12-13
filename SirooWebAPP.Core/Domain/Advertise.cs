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
    public class Advertise : AuditableBaseEntity
    {
        //[Key]
        //public Int64 AdvertiseID { get; set; }
        public bool IsVideo { get; set; }
        public int LikeReward { get; set; }
        public int ViewReward { get; set; }
        public DateTime Expiracy { get; set; }
        public string? Notes { get; set; }
        public string Caption { get; set; }
        public int ViewQuota { get; set; }
        public int RemainedViewQuota { get; set; }
        public bool? IsSpecial { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid CreatedBy { get; set; }
        public string MediaSourceURL { get; set; }
        public bool IsAvtivated { get; set; }
        public bool IsRejected { get; set; }
        public Guid Owner { get; set; }
        public bool? IsPremium { get; set; }



    }
}
