using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class AddRole
    {
        public Guid CreatedBy { get; set; }
        [Required(ErrorMessage ="اجباری")]
        [StringLength(20, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "اجباری")]
        public string Description { get; set; }
        public bool isActive { get; set; }

    }
}