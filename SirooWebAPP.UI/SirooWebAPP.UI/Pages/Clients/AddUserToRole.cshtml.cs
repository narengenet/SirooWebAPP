using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class AddUserToRoleModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public AddUserToRoleModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        public List<SelectListItem> RolesOptions { get; set; }
        public List<SelectListItem> UserOptions { get; set; }

        [BindProperty]
        public AddRoleUserModel? AddRoleUserModel { get; set; }


        public void OnGet()
        {
            //this.Users = new SelectList(this._usersServices.GetAllUsers(), "Id", "UserName");

            UserOptions = _usersServices.GetAllUsers().Select(a =>
                new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Username
                }
            ).ToList();

            CreateRolesOptionList();
        }

        public string? ResultMessage;


        public IActionResult OnPostAddRoleToUser(AddRoleUserModel addRoleUserModel)
        {
            if (ModelState.IsValid)
            {
                List<UsersRoles> _usrRoles = _usersServices.GetAllUsersRoles().Where(ur => ur.User == addRoleUserModel.UserID && ur.Role == addRoleUserModel.RoleID && ur.IsDeleted==false).ToList<UsersRoles>();
                if (_usrRoles.Count==0)
                {
                    string _creatorId = HelperFunctions.GetCookie("userid", Request);
                    Guid creatorID = Guid.Parse(_creatorId);
                    UsersRoles _ur = new UsersRoles
                    {
                        User = addRoleUserModel.UserID,
                        Role = addRoleUserModel.RoleID,
                        Created = DateTime.Now,
                        CreatedBy = creatorID
                    };
                    _usersServices.AddUserToRole(_ur);
                    ResultMessage = "نقش کاربر اضافه شد";
                }
                else
                {
                    ResultMessage = "قبلا این نقش به این کاربر اضافه شده بود.";
                }

            }


            UserOptions = _usersServices.GetAllUsers().Select(a =>
                new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Username
                }
            ).ToList();
            RolesOptions = _usersServices.GetAllRoles().Select(a =>
                new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.RoleDescription
                }
            ).ToList();
            return Page();

        }
        public IActionResult OnPostRemoveRoleFromUser(AddRoleUserModel addRoleUserModel)
        {
            if (ModelState.IsValid)
            {
                List<UsersRoles> _usrRoles = _usersServices.GetAllUsersRoles().Where(ur => ur.User == addRoleUserModel.UserID && ur.Role == addRoleUserModel.RoleID && ur.IsDeleted==false).ToList<UsersRoles>();
                if (_usrRoles.Count==1)
                {
                    string _creatorId = HelperFunctions.GetCookie("userid", Request);
                    Guid creatorID = Guid.Parse(_creatorId);

                    _usersServices.RemoveUserFromRole(_usrRoles.FirstOrDefault<UsersRoles>(),creatorID);
                    ResultMessage = "نقش کاربر حذف شد";
                }
                else
                {
                    ResultMessage = "این نقش برای این کاربر وجود ندارد.";
                }

            }


            UserOptions = _usersServices.GetAllUsers().Select(a =>
                new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Username
                }
            ).ToList();

            CreateRolesOptionList();
            return Page();

        }

        private void CreateRolesOptionList()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Roles highestPriorityRoleOfCreator = _usersServices.GetUserRoles(creatorID).OrderBy(r => r.Priority).FirstOrDefault<Roles>();

            RolesOptions = _usersServices.GetAllRoles()
                .Where(r => r.Priority > highestPriorityRoleOfCreator.Priority)
                .OrderBy(r=>r.Priority)
                .Select(a =>
                new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.RoleDescription
                }
            ).ToList();
        }
    }
}
