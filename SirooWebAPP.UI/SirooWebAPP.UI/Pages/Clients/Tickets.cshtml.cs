using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class TicketsModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public TicketsModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        [BindProperty(Name = "pagee", SupportsGet = true)]
        public int? pagee { get; set; }



        public void OnGetDisplay()
        {


            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);

            allYourContactsCount = 0;
            int thePage = 0;
            if (pagee != null)
            {
                thePage = Convert.ToInt32(pagee);
                if (thePage == -1)
                {
                    thePage = 0;
                }
            }

            allYourContactsCount = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).ToList<Contacts>().Count;
            contacts = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<Contacts>();
            if (contacts.Count >0)
            {

                hasValue = true;
                haveNext = thePage;
            }
            else
            {
                haveNext = thePage;
                hasValue = false;
            }

        }


        [BindProperty]
        public AddContactModel? AddContactModel { get; set; }

        [BindProperty]
        public List<Contacts> contacts { get; set; }



        public int allYourContactsCount { get; set; }

        [BindProperty]
        public int haveNext { get; set; }

        [BindProperty]
        public bool hasValue { get; set; }



        public void OnGet()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);

            allYourContactsCount = 0;
            int thePage = 0;
            if (pagee != null)
            {
                thePage = Convert.ToInt32(pagee);
                if (thePage == -1)
                {
                    thePage = 0;
                }
            }

            allYourContactsCount = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).ToList<Contacts>().Count;
            contacts = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<Contacts>();
            if (contacts.Count > 0)
            {

                hasValue = true;
                haveNext = thePage;
            }
            else
            {
                haveNext = thePage;
                hasValue = false;
            }

        }

        public string? ResultMessage;
        public IActionResult OnPostAddTicket(AddContactModel addContactModel)
        {

            if (ModelState.IsValid)
            {
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);

                Contacts contact = new Contacts
                {
                    Created = DateTime.Now,
                    FromUser = creatorID,
                    TheMessage = addContactModel.ContactText
                };

                _usersServices.AddContacts(contact);
                ResultMessage = "پیام شما ارسال شد.";

            }


            return Page();
        }
    }
}
