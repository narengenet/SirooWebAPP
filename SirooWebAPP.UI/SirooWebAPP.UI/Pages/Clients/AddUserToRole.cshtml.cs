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

            CreateOptions();
        }

        public string? ResultMessage;


        public IActionResult OnPostAddRoleToUser(AddRoleUserModel addRoleUserModel)
        {
            if (ModelState.IsValid)
            {
                bool permitToAdd = true;
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);

                // check new role
                Roles _newRole = _usersServices.GetRole(addRoleUserModel.RoleID);
                if (_newRole != null)
                {
                    // check creator role
                    Roles _creatorHighestRole = _usersServices.GetUserRoles(creatorID).OrderBy(r => r.Priority).First();
                    // check requested client's highest role
                    Roles _requestedUserHighestRole = _usersServices.GetUserRoles(AddRoleUserModel.UserID).OrderBy(r => r.Priority).First();
                    if (_creatorHighestRole.Priority > _requestedUserHighestRole.Priority)
                    {
                        permitToAdd = false;
                        ResultMessage = "شما اجازه اضافه کردن نقش به این کاربر را ندارید.";
                    }

                    //// check if new role is client or not
                    //if (_newRole.Priority == 5 && permitToAdd)
                    //{
                    //    // user with role or roles other than client can not be as client
                    //    List<UsersRoles> _beforeUserRoles = _usersServices.GetAllUsersRoles().Where(ur => ur.User == addRoleUserModel.UserID).ToList<UsersRoles>();
                    //    if (_beforeUserRoles.Count > 0)
                    //    {
                    //        permitToAdd = false;
                    //        ResultMessage = "این کاربر قبلا نقش دیگری داشته و نمیتواند مشتری شود.";
                    //    }
                    //}

                    // user with role or roles other than client can not be changed with non super or non admin user
                    UsersRoles _beforeUserRoles = _usersServices.GetAllUsersRoles().Where(ur => ur.User == addRoleUserModel.UserID).FirstOrDefault();
                    if (_beforeUserRoles.CreatedBy != _beforeUserRoles.User)
                    {
                        //if (_beforeUserRoles.CreatedBy != creatorID)
                        //{
                        if (_creatorHighestRole.RoleName != "super" || _creatorHighestRole.RoleName != "admin")
                        {
                            permitToAdd = false;
                            ResultMessage = "شما اجازه تغییر نقش این کاربر را ندارید.";
                        }

                        //}

                    }


                }
                else
                {
                    // *** penetration ***
                    permitToAdd = false;
                    ResultMessage = "چنین نقشی وجود ندارد.";
                }

                List<UsersRoles> _usrRoles = _usersServices.GetAllUsersRoles().Where(ur => ur.User == addRoleUserModel.UserID && ur.Role == addRoleUserModel.RoleID && ur.IsDeleted == false).ToList<UsersRoles>();
                if (_usrRoles.Count == 0 && permitToAdd)
                {
                    UsersRoles _ur = new UsersRoles
                    {
                        User = addRoleUserModel.UserID,
                        Role = addRoleUserModel.RoleID,
                        Created = DateTime.Now,
                        CreatedBy = creatorID
                    };

                    // remove previous role for this user
                    UsersRoles _previousUserRole = _usersServices.GetAllUsersRoles().Where(u => u.User == addRoleUserModel.UserID).FirstOrDefault();
                    if (_previousUserRole != null)
                    {
                        _usersServices.RemoveUserFromRole(_previousUserRole, creatorID);
                        ResultMessage = "نقش قبلی این کاربر حذف شد. ";
                    }

                    // add role to user
                    _usersServices.AddUserToRole(_ur);
                    ResultMessage += "نقش جدید کاربر اضافه شد.";
                }
                else if (permitToAdd)
                {
                    ResultMessage = "قبلا این نقش به این کاربر اضافه شده بود.";
                }

            }


            CreateOptions();
            return Page();

        }
        //public IActionResult OnPostRemoveRoleFromUser(AddRoleUserModel addRoleUserModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool permitToDelete = true;
        //        string _creatorId = HelperFunctions.GetCookie("userid", Request);
        //        Guid creatorID = Guid.Parse(_creatorId);

        //        // get remover role
        //        Roles _creatorRole = _usersServices.GetUserRoles(creatorID).OrderBy(c => c.Priority).First();
        //        Roles _requestedUserRole = _usersServices.GetUserRoles(addRoleUserModel.UserID).OrderBy(c => c.Priority).First();
        //        Roles _removingRole = _usersServices.GetRole(addRoleUserModel.RoleID);


        //        // *** penetrate ***
        //        // if remover role is lesser priority than requested user's role, he/she can not remove requested user's role
        //        if (_creatorRole.Priority>_removingRole.Priority)
        //        {
        //            permitToDelete = false;
        //            ResultMessage = "شما دسترسی به حذف این نقش ازین کاربر را ندارید.";
        //        }

        //        // check if remover role's priority is higher than requested user's priority or not
        //        if (_creatorRole.Priority>_requestedUserRole.Priority && permitToDelete)
        //        {
        //            permitToDelete = false;
        //            ResultMessage = "شما دسترسی به حذف این نقش ازین کاربر را ندارید.";

        //        }

        //        List<UsersRoles> _usrRoles = _usersServices.GetAllUsersRoles().Where(ur => ur.User == addRoleUserModel.UserID && ur.Role == addRoleUserModel.RoleID && ur.IsDeleted == false).ToList<UsersRoles>();
        //        if (_usrRoles.Count == 1 && permitToDelete)
        //        {


        //            _usersServices.RemoveUserFromRole(_usrRoles.FirstOrDefault<UsersRoles>(), creatorID);
        //            ResultMessage = "نقش کاربر حذف شد";
        //        }
        //        else if(permitToDelete)
        //        {
        //            ResultMessage = "این نقش برای این کاربر وجود ندارد.";
        //        }

        //    }


        //    CreateOptions();
        //    return Page();

        //}

        private void CreateOptions()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);

            UserOptions = _usersServices.GetAllLesserPriorityUsers(creatorID).Select(a =>
                                                                new SelectListItem
                                                                {
                                                                    Value = a.UserId.ToString(),
                                                                    Text = a.Username
                                                                }
                                                            ).ToList();
            //UserOptions = _usersServices.GetAllUsers().Select(a =>
            //                                                    new SelectListItem
            //                                                    {
            //                                                        Value = a.Id.ToString(),
            //                                                        Text = a.Username
            //                                                    }
            //                                                ).ToList();

            CreateRolesOptionList();
        }
        private void CreateRolesOptionList()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Roles highestPriorityRoleOfCreator = _usersServices.GetUserRoles(creatorID).OrderBy(r => r.Priority).FirstOrDefault<Roles>();

            RolesOptions = _usersServices.GetAllRoles()
                .Where(r => r.Priority > highestPriorityRoleOfCreator.Priority)
                .OrderBy(r => r.Priority)
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
