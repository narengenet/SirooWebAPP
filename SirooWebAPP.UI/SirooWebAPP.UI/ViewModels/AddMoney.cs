using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.ViewModels
{
    public class AddMoney
    {
        [Required(ErrorMessage = "حتما باید مبلغ افزایش کیف پول وارد شود.")]
        [Range(1000000, long.MaxValue, ErrorMessage = "حداقل مبلغ باید 1،000،000 ریال باشد.")]
        public long NewAmount{ get; set; }
    }
}
