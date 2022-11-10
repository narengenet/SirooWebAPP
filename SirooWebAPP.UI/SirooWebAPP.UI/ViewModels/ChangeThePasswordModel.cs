using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SirooWebAPP.UI.Pages
{

    public class ChangeThePassword
    {
        [Required]
        public Guid UserID { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "کلمه عبور باید حداقل 6 کاراکتر باشد.")]
        [DataType(DataType.Password)]
        public string CurrentConfirmationCode { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "کلمه عبور جدید باید حداقل 6 کاراکتر باشد.")]
        [DataType(DataType.Password)]
        public string ConfirmationCode { get; set; }

        [Required(ErrorMessage = "rePassword is required.")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "کلمه عبور جدید باید حداقل 6 کاراکتر باشد.")]
        [Compare("ConfirmationCode", ErrorMessage = "تکرارکلمه عبور جدید و کلمه عبورجدید باید یکسان باشند.")]
        [DataType(DataType.Password)]
        public string reConfirmationCode { get; set; }






    }
}