using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.ViewModels
{
    public class ReceiveMoney
    {
        [Required(ErrorMessage = "حتما باید مبلغ افزایش کیف پول وارد شود.")]
        [Range(100000, long.MaxValue, ErrorMessage = "حداقل مبلغ باید 100،000 ریال باشد.")]
        public long GetAmount { get; set; }

        [Required(ErrorMessage ="شماره کارت یا شبا حتما باید وارد شود")]
        public string? CardNumber { get; set; }
    }
}
