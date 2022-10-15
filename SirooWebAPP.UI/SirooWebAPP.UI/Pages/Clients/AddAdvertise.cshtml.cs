using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class AddAdvertiseModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public AddAdvertiseModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        public List<SelectListItem> Options { get; set; }

        [BindProperty]
        public AddAds? AddAds { get; set; }
        public string FileName { get; set; }
        public bool IsVideo { get; set; }

        public string ResultMessage = "";
        public bool ResultMessageSuccess = false;

        public void OnGet()
        {
            CreateOptionList();

        }

        private void CreateOptionList()
        {
            Options = new List<SelectListItem>();
            List<Users> theUsers = _usersServices.GetAllUsers();
            bool isSelected = false;
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            foreach (var item in theUsers)
            {
                isSelected = false;
                if (item.Id == creatorID)
                {
                    isSelected = true;
                }
                Options.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Username,
                    Selected = isSelected
                });

            }
        }

        public IActionResult OnPostAddAdvertisements(AddAds addAds)
        {
            Guid tmp_userid = addAds.UserID;

            //string strYear = DateTime.Now.Year.ToString();
            //string strMonth = DateTime.Now.Month.ToString();

            //bool exists = System.IO.Directory.Exists(_environment.WebRootPath + "/uploads/" + strYear);

            //if (!exists)
            //    System.IO.Directory.CreateDirectory(_environment.WebRootPath + "/uploads/" + strYear);

            //exists = System.IO.Directory.Exists(_environment.WebRootPath + "/uploads/" + strYear + "/" + strMonth);

            //if (!exists)
            //    System.IO.Directory.CreateDirectory(_environment.WebRootPath + "/uploads/" + strYear + "/" + strMonth);

            int random_number = new Random().Next(10000, 99999);
            string prefix = tmp_userid.ToString() + "-" + random_number.ToString() + "-";// + addAds.Upload.FileName;
            //var path = Path.Combine(_environment.WebRootPath, "uploads/" + strYear + "/" + strMonth, FileName);
            //var stream = new FileStream(path, FileMode.Create);
            //addAds.Upload.CopyToAsync(stream);
            //FileName = "uploads/" + strYear + "/" + strMonth + "/" + FileName;

            FileName = HelperFunctions.UploadFileToDateBasedFolder(prefix, addAds.Upload, _environment);
            string _creatorId= HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);

            Advertise ads = new Advertise
            {
                Name = addAds.Name,
                Caption = addAds.Caption,
                CreationDate = DateTime.Now,
                Expiracy = addAds.Expiracy,
                Owner = addAds.UserID,
                IsVideo = addAds.isVideo,
                LikeReward = addAds.LikeReward,
                ViewReward = addAds.ViewReward,
                ViewQuota = addAds.ViewQuota,
                CreatedBy= creatorID,
                MediaSourceURL = FileName

            };

            _usersServices.AddAvertise(ads, tmp_userid);






            CreateOptionList();

            IsVideo = ads.IsVideo;
            ResultMessage = "پَست جدید ارسال شد. لطفا منتظر تایید بمانید.";
            ResultMessageSuccess = true;
            return Page();

        }
    }
}
