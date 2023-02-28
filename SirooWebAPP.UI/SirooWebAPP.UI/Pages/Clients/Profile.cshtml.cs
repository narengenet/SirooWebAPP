using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class ProfileModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;
        private readonly ISession session;
        private readonly IHttpContextAccessor _httpContextAccessor;

        [BindProperty]
        public IFormFile UploadProfile { get; set; }


        public string ResultMessage = "";
        public string ResultMessageSuccess = "danger";

        public ProfileModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;
            session = httpContextAccessor.HttpContext.Session;
            _httpContextAccessor = httpContextAccessor;


        }
        public DTOUserProfile _currentUser = new DTOUserProfile();
        public string roleName = "anonymous";
        public string InvitationLink = "";
        public string qrLinkSrc = "";

        public void OnGet()
        {

            InitiateThePage();
        }


        private void InitiateThePage()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            _currentUser = _usersServices.GetUserProfile(creatorID);
            roleName = session.GetString("userroledescription");
            InvitationLink = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value + "/Registeration/Register?inviter=" + _currentUser.Username;
            qrLinkSrc = HelperFunctions.CreateQR(InvitationLink);
        }

        public IActionResult OnPostAddProfileImage()
        {
            bool condition = true;
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            Users _currentUser = _usersServices.GetUser(creatorID);
            if (_currentUser==null)
            {
                condition = false;
                InitiateThePage();
                return Page();
            }

            if (UploadProfile==null)
            {
                ResultMessage = "ابتدا فایل تصویر پروفایل جدید را انتخاب نمایید.";
                ResultMessageSuccess = "danger";
                condition = false;
                InitiateThePage();
                return Page();
            }

            if (UploadProfile.Length > 3145728)
            {
                ResultMessage = "حجم فایل نباید بیشتر از 3 مگابایت باشد.";
                ResultMessageSuccess = "danger";
                condition = false;
            }

            if (!condition)
            {
                InitiateThePage();

                return Page();
            }

            string[] filetypes = { "image/gif", "image/jpeg", "image/png", "image/bmp" };
            if (!filetypes.Contains(UploadProfile.ContentType))
            {
                ResultMessage += " فایل باید یکی از فرمت های: jpg,png,bmp,gif باشد.";
                ResultMessageSuccess = "danger";
                condition = false;
            }

            int random_number = new Random().Next(10000, 99999);
            string prefix = _creatorId.ToString() + "-" + random_number.ToString() + "-";// + addAds.Upload.FileName;
            if (UploadProfile != null && condition)
            {
                string FileName = HelperFunctions.UploadFileToDateBasedFolder(prefix, UploadProfile, false, _environment,true,200);
                if (FileName != "-1")
                {
                    _currentUser.ProfileMediaURL = FileName;
                    _usersServices.UpdateUser(_currentUser);
                    ResultMessage = "تصویر پروفایل شما بروز شد.";
                    ResultMessageSuccess = "success";
                }
            }

            InitiateThePage();

            return Page();
        }

    }
}
