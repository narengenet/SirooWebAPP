using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class AddDraw
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        public bool IsLottery { get; set; }
        public bool IsActivated { get; set; }

    }
}