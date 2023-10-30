using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.ViewModels
{
    public class AddInsuranceThird
    {
        [Required(ErrorMessage = "ورود نام کاربری معرف اجباری است"), MinLength(6, ErrorMessage = "حداقل 6 کاراکتر")]

        public string Parent { get; set; }

        [Required(ErrorMessage = "ورود نام اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]

        public string TheName { get; set; }

        [Required(ErrorMessage = "ورود نام خانوادگی اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheFamily { get; set; }

        [Required(ErrorMessage = "ورود کدملی اجباری است"), MinLength(8, ErrorMessage = "کد ملی وارد شده صحیح نیست")]
        public string TheNationalID { get; set; }

        //[Required(ErrorMessage = "ورود کدملی ذی نفع اجباری است"), MinLength(8, ErrorMessage = "کد ملی وارد شده صحیح نیست")]
        //public string TheNationalIDPerson { get; set; }

        //[Required(ErrorMessage = "ورود نام و نام خانوادگی ذی نفع اجباری است"), MinLength(5, ErrorMessage = "حداقل 5 کاراکتر")]
        //public string TheFullNamePerson { get; set; }

        [Required(ErrorMessage = "ورود شماره شناسنامه اجباری است"), MinLength(1, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheIDNumber { get; set; }


        [Required(ErrorMessage = "ورود نام پدر اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheFatherName { get; set; }


        [Required(ErrorMessage = "ورود شماره موبایل اجباری است"), MinLength(10, ErrorMessage = "لطفا شماره موبایل را کامل وارد نمایید")]
        public string TheMobileNumber { get; set; }

        [Required(ErrorMessage = "ورود استان محل سکونت اجباری است"), MinLength(2, ErrorMessage = "لطفا استان محل سکومت را کامل وارد نمایید")]
        public string TheAddressProvience { get; set; }

        [Required(ErrorMessage = "ورود شهر محل سکونت اجباری است"), MinLength(2, ErrorMessage = "لطفا شهر محل سکومت را کامل وارد نمایید")]
        public string TheAddressCity { get; set; }

        [Required(ErrorMessage = "ورود نشانی محل سکونت اجباری است"), MinLength(2, ErrorMessage = "لطفا نشانی محل سکومت را کامل وارد نمایید")]
        public string TheAddressDetails { get; set; }

        [Required(ErrorMessage = "ورود کدپستی محل سکونت اجباری است"), MinLength(10, ErrorMessage = "لطفا کدپستی محل سکومت را کامل وارد نمایید")]
        public string TheAddressPostalCode { get; set; }

        [Range(0, 1, ErrorMessage = "شرایط بیمه نامه را باید قبول کنید.")]
        [Required(ErrorMessage = "شرایط بیمه نامه را باید بپذیرید.")]
        public int ThePolicy { get; set; }





        //public string? NeededMoneyToAttendInChallenge { get; set; }


    }
}

