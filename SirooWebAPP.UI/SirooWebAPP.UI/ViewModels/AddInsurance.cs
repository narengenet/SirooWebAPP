using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.ViewModels
{
    public class AddInsurance
    {
        [Required(ErrorMessage = "ورود نام کاربری معرف اجباری است"), MinLength(6, ErrorMessage = "حداقل 6 کاراکتر")]

        public string Parent { get; set; }

        [Required(ErrorMessage = "ورود نام اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]

        public string TheName { get; set; }

        [Required(ErrorMessage = "ورود نام خانوادگی اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheFamily { get; set; }

        [Required(ErrorMessage = "ورود کدملی اجباری است"), MinLength(8, ErrorMessage = "کد ملی وارد شده صحیح نیست")]
        public string TheNationalID { get; set; }

        [Required(ErrorMessage = "ورود شماره شناسنامه اجباری است"), MinLength(1, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheIDNumber { get; set; }

        [Required(ErrorMessage = "ورود تاریخ تولد اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheBirthDate { get; set; }

        [Required(ErrorMessage = "ورود نام پدر اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheFatherName { get; set; }
        
        [Required(ErrorMessage = "ورود محل صدور اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheIssuePlace { get; set; }

        [Range(1, 2, ErrorMessage = "جنسیت را تایین کنید")]
        [Required(ErrorMessage = "جنسیت را تکمیل نمایید")]
        public int TheGender { get; set; }

        [Range(1, 2, ErrorMessage = "وضعیت تاهل را تکمیل نمایید")]
        [Required(ErrorMessage = "وضعیت تاهل را تکمیل نمایید")]
        public int IsMarried { get; set; }

        [Required(ErrorMessage = "ورود قد اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheHeight { get; set; }

        [Required(ErrorMessage = "ورود وزن اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheWeight { get; set; }


        [Range(1, 5, ErrorMessage = "وضعیت نظام‌وظیفه را تایین کنید")]
        [Required(ErrorMessage = "وضعیت نظام‌وظیفه را تکمیل نمایید")]
        public int TheMilitaryServiceStatus { get; set; }

        [Required(ErrorMessage = "تلفن ثابت منزل خود را وارد کنید"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheResidentialPhone { get; set; }

        [Required(ErrorMessage = "ورود شماره موبایل اجباری است"), MinLength(10, ErrorMessage = "لطفا شماره موبایل را کامل وارد نمایید")]
        public string TheMobileNumber { get; set; }

        [Required(ErrorMessage = "ورود عنوان شغلی اجباری است"), MinLength(2, ErrorMessage = "لطفا شغل را کامل وارد نمایید")]
        public string TheJobTitle { get; set; }

        [Required(ErrorMessage = "ورود استان محل سکونت اجباری است"), MinLength(2, ErrorMessage = "لطفا استان محل سکومت را کامل وارد نمایید")]
        public string TheAddressProvience { get; set; }

        [Required(ErrorMessage = "ورود شهر محل سکونت اجباری است"), MinLength(2, ErrorMessage = "لطفا شهر محل سکومت را کامل وارد نمایید")]
        public string TheAddressCity { get; set; }

        [Required(ErrorMessage = "ورود نشانی محل سکونت اجباری است"), MinLength(2, ErrorMessage = "لطفا نشانی محل سکومت را کامل وارد نمایید")]
        public string TheAddressDetails { get; set; }
        
        [Required(ErrorMessage = "ورود کدپستی محل سکونت اجباری است"), MinLength(10, ErrorMessage = "لطفا کدپستی محل سکومت را کامل وارد نمایید")]
        public string TheAddressPostalCode { get; set; }

        [Range(1, 2, ErrorMessage = "وضعیت زندگی پدرتان را تکمیل نمایید")]
        [Required(ErrorMessage = "وضعیت زندگی پدرتان را تکمیل نمایید")]
        public int TheFatherAlive { get; set; }

        [Range(1, 2, ErrorMessage = "وضعیت  زندگی مادرتان را تکمیل نمایید")]
        [Required(ErrorMessage = "وضعیت زندگی مادرتان را تکمیل نمایید")]
        public int TheMotherAlive { get; set; }



        //public string? NeededMoneyToAttendInChallenge { get; set; }


    }
}
