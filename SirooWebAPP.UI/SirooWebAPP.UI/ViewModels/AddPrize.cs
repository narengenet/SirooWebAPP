using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class AddPrize
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid DrawId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "تعداد برنده هر جایزه حداقل باید 1 نفر باشد.")]
        public int  WinnerCount { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "اولیت هر جایزه حداقل باید صفر باشد")]
        public int Priority { get; set; }
        public bool IsActivated { get; set; }

    }
}