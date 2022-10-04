using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class LoginPerson
    {
        [Required]
        public string? Cellphone { get; set; }
    }
}