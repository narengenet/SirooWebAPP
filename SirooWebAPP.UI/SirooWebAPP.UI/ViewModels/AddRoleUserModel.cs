using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class AddRoleUserModel
    {
       
        [Required(ErrorMessage = "اجباری")]
        public Guid UserID { get; set; }
        [Required(ErrorMessage = "اجباری")]
        public Guid RoleID { get; set; }

    }
}