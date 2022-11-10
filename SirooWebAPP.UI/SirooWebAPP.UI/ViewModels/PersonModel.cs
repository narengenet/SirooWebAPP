using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class Person
    {
        [Required(ErrorMessage = "درج نام شما اجباری است."), StringLength(30)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "درج نام‌خانوادگی شما اجباری است."), StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "درج نام کاربری اجباری است."), StringLength(20),MinLength(5,ErrorMessage ="حداقل 5 کاراکتر")]
        [Remote("VerifyUsername", "Users")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="درج شماره تلفن همراه اجباری است.")]
        [Remote("VerifyPhone","Users")]
        public string CellPhone { get; set; }
        public string? InviterUsername { get; set; }
        public Guid InviterUserID { get; set; }
        //[Required]
        //[EmailAddress]
        //[Remote("Details","Products")]
        //public string Email { get; set; }


    }
}