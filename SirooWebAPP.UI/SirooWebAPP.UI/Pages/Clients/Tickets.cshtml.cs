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


            //string _creatorId = HelperFunctions.GetCookie("userid", Request);
            //Guid creatorID = Guid.Parse(_creatorId);

            //allYourContactsCount = 0;
            //int thePage = 0;
            //if (pagee != null)
            //{
            //    thePage = Convert.ToInt32(pagee);
            //    if (thePage == -1)
            //    {
            //        thePage = 0;
            //    }
            //}

            //allYourContactsCount = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).ToList<Contacts>().Count;
            //contacts = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<Contacts>();
            //if (contacts.Count > 0)
            //{

            //    hasValue = true;
            //    haveNext = thePage;
            //}
            //else
            //{
            //    haveNext = thePage;
            //    hasValue = false;
            //}

        }


        [BindProperty]
        public AddContactModel? AddContactModel { get; set; }

        [BindProperty]
        public List<ContactViewModel> contacts { get; set; }



        public int allYourContactsCount { get; set; }

        [BindProperty]
        public int haveNext { get; set; }

        [BindProperty]
        public bool hasValue { get; set; }

        [BindProperty]
        public bool IsAdmin { get; set; }



        public void OnGet()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);


            Guid creatorID = Guid.Parse(_creatorId);
            Roles usrRole = _usersServices.GetUserRoles(creatorID).Where(ur => ur.Priority < 2).FirstOrDefault();
            if (usrRole != null)
            {
                IsAdmin = true;
            }

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

            List<Contacts> _contacts = new List<Contacts>();
            contacts = new List<ContactViewModel>();

            if (IsAdmin)
            {
                allYourContactsCount = _usersServices.GetAllContacts().ToList<Contacts>().Count;
                _contacts = _usersServices.GetAllContacts().OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<Contacts>();

            }
            else
            {
                allYourContactsCount = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).ToList<Contacts>().Count;
                _contacts = _usersServices.GetAllContacts().Where(c => c.FromUser == creatorID).OrderByDescending(t => t.Created).Skip(thePage * 10).Take(10).ToList<Contacts>();
            }



            if (_contacts.Count > 0)
            {

                hasValue = true;
                haveNext = thePage;
            }
            else
            {
                haveNext = thePage;
                hasValue = false;
            }

            foreach (Contacts item in _contacts)
            {
                Users _usr = _usersServices.GetAllUsersEvenDeleted().Where(u => u.Id == item.FromUser).FirstOrDefault();
                string isDeleted = "";
                if (_usr.IsDeleted)
                {
                    isDeleted = "(حذف شده)";
                }
                contacts.Add(new ContactViewModel
                {
                    Id = item.Id,
                    Created = item.Created,
                    FromUser = item.FromUser,
                    Username = _usr.Username+isDeleted,
                    IsRead = item.IsRead,
                    IsReplied = item.IsReplied,
                    TheMessage = item.TheMessage,
                    ReplyMessage = item.ReplyMessage,
                    ReadDate = item.ReadDate,
                    ReplyDate = item.ReplyDate

                });
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
