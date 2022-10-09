using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class AddRoleModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public AddRoleModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        //public List<SelectListItem> Options { get; set; }
        //public List<SelectListItem> UserOptions { get; set; }

        [BindProperty]
        public AddRole? AddRole { get; set; }
        //public string FileName { get; set; }
        //public bool IsVideo { get; set; }

        public void OnGet()
        {
            //this.Users = new SelectList(this._usersServices.GetAllUsers(), "Id", "UserName");

            //UserOptions = _usersServices.GetAllUsers().Select(a =>
            //    new SelectListItem
            //    {
            //        Value = a.Id.ToString(),
            //        Text = a.Username
            //    }
            //).ToList();
            //Options = _usersServices.GetAllRoles().Select(a =>
            //    new SelectListItem
            //    {
            //        Value = a.Id.ToString(),
            //        Text = a.RoleDescription
            //    }
            //).ToList();
        }

        public string? ResultMessage;

        public IActionResult OnPostAddRole(AddRole addRole)
        {
            if (ModelState.IsValid)
            {
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Roles _r = _usersServices.GetRoleByName(addRole.Name);
                if (_r == null)
                {
                    Roles role = new Roles
                    {
                        CreatedBy = creatorID,
                        Created = DateTime.Now,
                        IsActivated = addRole.isActive,
                        RoleName = addRole.Name,
                        RoleDescription = addRole.Description
                    };
                    _usersServices.AddRole(role);
                    ResultMessage = "نقش جدید ایحاد شد.";
                }
                else
                {
                    ResultMessage = "قبلا ایجاد شده است.";
                }

            }


            //int random_number = new Random().Next(10000, 99999);


            //FileName = HelperFunctions.UploadFileToDateBasedFolder(prefix, addAds.Upload, _environment);
            //string _creatorId = HelperFunctions.GetCookie("userid", Request);
            //Guid creatorID = Guid.Parse(_creatorId);

            //Advertise ads = new Advertise
            //{
            //    Name = addAds.Name,
            //    Caption = addAds.Caption,
            //    CreationDate = DateTime.Now,
            //    Expiracy = addAds.Expiracy,
            //    Owner = addAds.UserID,
            //    IsVideo = addAds.isVideo,
            //    LikeReward = addAds.LikeReward,
            //    ViewReward = addAds.ViewReward,
            //    ViewQuota = addAds.ViewQuota,
            //    CreatedBy = creatorID,
            //    MediaSourceURL = FileName

            //};

            //_usersServices.AddAvertise(ads, tmp_userid);







            //Options = _usersServices.GetAllUsers().Select(a =>
            //                                                new SelectListItem
            //                                                {
            //                                                    Value = a.Id.ToString(),
            //                                                    Text = a.Username
            //                                                }
            //                                            ).ToList();
            //IsVideo = ads.IsVideo;

            //UserOptions = _usersServices.GetAllUsers().Select(a =>
            //    new SelectListItem
            //    {
            //        Value = a.Id.ToString(),
            //        Text = a.Username
            //    }
            //).ToList();
            //Options = _usersServices.GetAllRoles().Select(a =>
            //    new SelectListItem
            //    {
            //        Value = a.Id.ToString(),
            //        Text = a.RoleDescription
            //    }
            //).ToList();
            return Page();

        }
    }
}
