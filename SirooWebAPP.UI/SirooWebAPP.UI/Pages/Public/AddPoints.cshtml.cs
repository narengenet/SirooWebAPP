using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Public
{
    public class AddPointsModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private readonly ISession session;
        

        public AddPointsModel(CustomIDataProtection customIDataProtection, IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session= httpContextAccessor.HttpContext.Session;
            

        }
        public void OnGet()
        {
            string ticket = Request.Query["ticket"].ToString();
            if (ticket!=null)
            {
                Guid ticketId = Guid.Parse(ticket);
                DonnationTickets theTicket= _usersServices.GetDonnationTicket(ticketId);
                if (theTicket!=null)
                {
                    Roles storeRole= _usersServices.GetUserRoles(theTicket.Donner).OrderBy(r => r.Priority).First();
                    if (storeRole.RoleName=="store")
                    {
                        this.session.SetString("store_donate", theTicket.Donner.ToString());
                        this.session.SetString("ticket_donate", ticket);

                        HelperFunctions.SetCookie("store_donate", theTicket.Donner.ToString(), 1, HttpContext.Response);
                        HelperFunctions.SetCookie("ticket_donate", ticket, 1, HttpContext.Response);
                    }
                }
            }
            Response.Redirect("../Clients/Main");
        }
    }
}
