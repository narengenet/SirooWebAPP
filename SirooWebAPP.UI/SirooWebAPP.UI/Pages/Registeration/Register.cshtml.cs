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
        private readonly ISession session;



        public RegisterModel(CustomIDataProtection customIDataProtection,IUserServices services, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            session = httpContextAccessor.HttpContext.Session;


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
                


                // get default role for new registered user
                Roles _newRole = _usersServices.GetAllRoles().OrderByDescending(r => r.Priority).FirstOrDefault<Roles>();
                
                // check if donation is used recently or not
                // and check if inviter is exist or not
                string? storeDonation = session.GetString("store_donate");
                if (storeDonation!=null && inviter==null)
                {
                    Guid storeId = Guid.Parse(storeDonation);
                    Users storeUser = _usersServices.GetUser(storeId);
                    if (storeUser!=null)
                    {

                        // check if donner is a store or not
                        Roles storeRole = _usersServices.GetUserRoles(storeId).OrderBy(r => r.Priority).First();
                        if (storeRole.RoleName != "store")
                        {
                            session.Remove("store_donate");
                        }
                        else
                        {
                            // if inviter is null and recently a ticket has been used, then use store as inviter
                            inviter = storeUser;
                        }
                    }
                    else
                    {
                        session.Remove("store_donate");
                    }
                }

                // create new user and register as a user
                Users _newUser = new Users { Name = person.FirstName, Family = person.LastName, Cellphone = person.CellPhone, Username = person.UserName, ConfirmationCode = _confirmationCode.ToString(), Inviter = inviter };
                Guid result = _usersServices.AddUser(_newUser);

                UsersRoles _newUserRole = new UsersRoles { User = result, Role = _newRole.Id, Created = DateTime.Now, CreatedBy = result };
                _usersServices.AddUserToRole(_newUserRole);

               
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
