using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class AddAds
    {
        [Required]
        public Guid UserID { get; set; }
        public string? Notes { get; set; }
        public string Caption { get; set; }
        public string MediaURL { get; set; }
        public bool isVideo { get; set; }
        public int LikeReward { get; set; }
        public int ViewReward { get; set; }
        public int ViewQuota { get; set; }
        public DateTime Expiracy { get; set; }
        public IFormFile Upload { get; set; }
        public bool IsPremium { get; set; }
        public bool IsSpecial { get; set; }

    }
}