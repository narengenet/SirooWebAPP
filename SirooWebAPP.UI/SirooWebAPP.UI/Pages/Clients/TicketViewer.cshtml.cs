using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class TicketViewerModel : PageModel
    {
        private readonly IUserServices _usersServices;
        
        private IWebHostEnvironment _environment;


        public TicketViewerModel(IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            _environment = environment;

        }

        [BindProperty(Name = "ticket", SupportsGet = true)]
        public Guid? ticket { get; set; }



        [BindProperty]
        public bool IsAdmin { get; set; }


        [BindProperty]
        public Contacts TheContact { get; set; }

        public void OnGet()
        {
            if (ticket!=null)
            {
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Roles usrRole = _usersServices.GetUserRoles(creatorID).Where(ur => ur.Priority < 2).FirstOrDefault();
                if (usrRole != null)
                {
                    IsAdmin = true;
                }



                Contacts contact= _usersServices.GetAllContacts().Where(c => c.Id == ticket).FirstOrDefault();
                if (contact!=null)
                {
                    TheContact = contact;

                    if (contact.IsRead==false && IsAdmin)
                    {
                        contact.IsRead = true;
                        contact.ReadDate = DateTime.Now;

                        _usersServices.UpdateContacts(contact);
                    }
                }
            }
        }
    }
}
