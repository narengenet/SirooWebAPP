using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Public
{
    public class ConfirmPaymentModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        public ConfirmPaymentModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;

        }

        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";
        public string RefCode = "";
        public string Amount = "";
        public bool IsSuccessfull = false;
        public string Status { get; set; }

        public void OnGet()
        {
            RefCode = Request.Query["ref"].ToString();
            Amount = Request.Query["amount"].ToString();
            Status = Request.Query["status"].ToString();
            IsSuccessfull = (Status == "success") ? true : false;
        }
    }
}
