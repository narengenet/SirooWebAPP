﻿using Microsoft.AspNetCore.Mvc;
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
        public string ResultMessageSuccess = "danger";


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
            bool condition = true;

            Guid tmp_userid = addAds.UserID;
            bool isGif = false;
            Users addOwner = _usersServices.GetUser(addAds.UserID);
            int moneyNeeded = 0;

            if (addAds.Upload.Length > 15728640)
            {
                ResultMessage = "حجم فایل نباید بیشتر از 15 مگابایت باشد.";
                ResultMessageSuccess = "danger";
                condition = false;
            }
            else
            {

                if (addAds.Upload.ContentType == "video/mp4")
                {
                    addAds.isVideo = true;
                }
                if (addAds.Upload.ContentType == "image/gif")
                {
                    addAds.isVideo = false;
                    isGif = true;
                }
                string[] filetypes = { "image/gif", "image/jpeg", "image/png", "image/bmp", "video/mpeg", "video/mp4" };
                if (!filetypes.Contains(addAds.Upload.ContentType))
                {
                    ResultMessage += " فایل باید یکی از فرمت های: jpg,png,bmp,gif,mpeg,mp4 باشد.";
                    ResultMessageSuccess = "danger";
                    condition = false;
                }

                if (addAds.IsPremium)
                {

                    if (addOwner != null)
                    {
                        string moneyRequiredKeyName = (addAds.isVideo == true) ? "def_money_to_premium_video_ads" : "def_money_to_premium_image_ads";
                        moneyNeeded = Convert.ToInt32(_usersServices.GetConstantDictionary(moneyRequiredKeyName).ConstantValue);
                        if (addOwner.Money < moneyNeeded)
                        {
                            ResultMessage += "برای ثبت آگهی تجاری";
                            ResultMessage += (addAds.isVideo) ? " ویدئویی " : " تصویری ";
                            ResultMessage += " مبلغ " + moneyNeeded + " ریال مورد نیاز است. لطفا کیف پول خود را شارژ نمایید.";
                            ResultMessageSuccess = "danger";
                            condition = false;
                        }
                    }


                }
            }


            int random_number = new Random().Next(10000, 99999);
            string prefix = tmp_userid.ToString() + "-" + random_number.ToString() + "-";// + addAds.Upload.FileName;
            if (addAds.Upload != null && addAds.Caption != null && condition)
            {
                FileName = HelperFunctions.UploadFileToDateBasedFolder(prefix, addAds.Upload, addAds.isVideo, _environment);
                if (FileName != "-1")
                {
                    string _creatorId = HelperFunctions.GetCookie("userid", Request);
                    Guid creatorID = Guid.Parse(_creatorId);

                    int defPointsImage = Convert.ToInt32(_usersServices.GetConstantDictionary("def_points_for_image_like").ConstantValue);
                    int defPointsVideo = Convert.ToInt32(_usersServices.GetConstantDictionary("def_points_for_video_like").ConstantValue);



                    if (condition)
                    {
                        Advertise ads = new Advertise
                        {
                            //Notes = addAds.Notes,
                            Caption = addAds.Caption,
                            CreationDate = DateTime.Now,
                            Expiracy = addAds.Expiracy,
                            Owner = addAds.UserID,
                            IsVideo = addAds.isVideo,
                            LikeReward = (addAds.isVideo) ? defPointsVideo : defPointsImage,
                            ViewReward = addAds.ViewReward,
                            ViewQuota = addAds.ViewQuota,
                            CreatedBy = creatorID,
                            MediaSourceURL = FileName,
                            IsPremium = addAds.IsPremium

                        };

                        _usersServices.AddAvertise(ads, tmp_userid);
                        if (addAds.IsPremium)
                        {
                            addOwner.Money -= moneyNeeded;
                            _usersServices.UpdateUser(addOwner);

                            _usersServices.AddTransaction(new Transactions
                            {
                                Amount = -1*moneyNeeded,
                                ReferenceID = ads.Id.ToString(),
                                Created = DateTime.Now,
                                User = addAds.UserID,
                                IsSuccessfull = true,
                                Status = "آگهی تجاری"

                            });
                        }






                        CreateOptionList();

                        IsVideo = ads.IsVideo;
                        ResultMessage = "پَست جدید ارسال شد. لطفا منتظر تایید بمانید.";
                        if (addAds.IsPremium)
                        {
                            ResultMessage += " مبلغ " + moneyNeeded + " ریال از کیف پول شما برداشت شد.";
                        }
                        ResultMessageSuccess = "success";
                    }
                }
                else
                {
                    ResultMessage += " فایل شما قابل شناسایی نیست.";
                    ResultMessageSuccess = "danger";
                }



            }
            else
            {


                ResultMessage += " لطفا همه آیتم ها را به درستی تکمیل نمایید.";
                ResultMessageSuccess = "danger";
            }


            return Page();

        }
    }
}
