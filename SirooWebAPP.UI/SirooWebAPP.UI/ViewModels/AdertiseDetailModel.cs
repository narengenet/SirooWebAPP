using SirooWebAPP.Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.ViewModels
{
    public class AdertiseDetailModel
    {
        [Required]
        public Int64 AdvertiseID { get; set; }
        public Users Owner { get; set; }
        public bool IsVideo { get; set; }
        public int LikeReward { get; set; }
        public int ViewReward { get; set; }
        public DateTime Expiracy { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public int ViewQuota { get; set; }
        public int RemainedViewQuota { get; set; }
        public bool? IsSpecial { get; set; }
        public DateTime CreationDate { get; set; }
        public string MediaSourceURL { get; set; }
        public ICollection<Users> Likers { get; set; }
    }
}
