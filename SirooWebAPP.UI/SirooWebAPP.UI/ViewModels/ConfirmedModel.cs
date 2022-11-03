using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class Confirmed
    {
        [Required]
        public Guid UserID { get; set; }
        public string ConfirmationCode { get; set; }
    }
}