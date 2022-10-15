using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.ViewModels
{
    public class AddQRModel
    {
        [Required(ErrorMessage ="حتما باید امتیاز QR تایین شود.")]
        [Range(1, 200, ErrorMessage = "حداکثر امتیاز برای هر QR 200 امتیاز است.")]
        public int Points { get; set; }
        [Required(ErrorMessage ="حتما باید تعداد مجاز اسکن این QR تایین شود.")]
        public int Capacity { get; set; }
    }
}
