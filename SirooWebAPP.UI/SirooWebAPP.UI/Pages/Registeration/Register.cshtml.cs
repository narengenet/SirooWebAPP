using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Contexts;
using SirooWebAPP.Infrastructure.Security;
using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;


        public RegisterModel(CustomIDataProtection customIDataProtection,IUserServices services)
        {
            _usersServices = services;
            protector = customIDataProtection;

        }
        public void OnGet()
        {
            string sin = "sina";
            string q=protector.Decode("sss");
            string inviter = Request.Query["inviter"].ToString();
            if (inviter!="")
            {
                Users inviterUsr= _usersServices.GetUserByUsername(inviter);
                if (inviterUsr!=null)
                {
                    ViewData["InviterUserID"]= inviterUsr.Id;
                }
                
            }

        }

        
        [BindProperty]
        public Person? Person { get; set; }


        public void OnPost(Person person)
        {
            if (ModelState.IsValid)
            {
                //this.Name = string.Format("Name: {0} {1}", person.FirstName, person.LastName);
            }
            
        }
        public IActionResult OnPostRegister(Person person)
        {
            if (ModelState.IsValid)
            {
                Random r = new Random();
                int _confirmationCode = r.Next(1000, 9999);
                Users inviter=(person.InviterUserID!=null)? _usersServices.GetUser(person.InviterUserID):null;
                
                Users _newUser = new Users { Name = person.FirstName, Family = person.LastName, Cellphone = person.CellPhone, Username = person.UserName, ConfirmationCode=_confirmationCode.ToString(), Inviter=inviter };
                Guid result=_usersServices.AddUser(_newUser);
               
                return RedirectToPage("Confirmation", "Display", new { UserID = result});

            }
            return Page();

        }
        public void OnPostView(Person person)
        {
            //this.Name = string.Format("Name: {0} {1}", person.FirstName, person.LastName);
        }


    }
}
