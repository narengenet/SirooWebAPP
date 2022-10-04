using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class Person
    {
        [Required, StringLength(30)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(20)]
        [Remote("VerifyUsername", "Users")]
        public string UserName { get; set; }
        [Required]
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