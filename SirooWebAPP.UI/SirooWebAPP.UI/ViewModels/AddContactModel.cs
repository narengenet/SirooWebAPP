using System.ComponentModel.DataAnnotations;
namespace SirooWebAPP.UI.ViewModels
{
    public class AddContactModel
    {
        [Required(ErrorMessage ="متن پیام باید حتما نوشته شود.")]
        public string ContactText { get; set; }
    }
}
