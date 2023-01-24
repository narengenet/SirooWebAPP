using System.ComponentModel.DataAnnotations;

namespace SirooWebAPP.UI.ViewModels
{
    public class AddChallenge
    {
        public string? Parent { get; set; }

        [Required(ErrorMessage = "ورود نام اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]

        public string TheName { get; set; }
        
        [Required(ErrorMessage = "ورود نام خانوادگی اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheFamily { get; set; }
        
        [Required(ErrorMessage = "ورود شماره شناسنامه اجباری است"), MinLength(1, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheIDNumber { get; set; }

        [Required(ErrorMessage = "ورود تاریخ تولد اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheBirthDate { get; set; }
        
        [Required(ErrorMessage = "ورود کدملی اجباری است"), MinLength(8, ErrorMessage = "کد ملی وارد شده صحیح نیست")]
        public string TheNationalID { get; set; }

        [Required(ErrorMessage = "ورود نام پدر اجباری است"), MinLength(2, ErrorMessage = "حداقل 2 کاراکتر")]
        public string TheFatherName { get; set; }
        
        
        public bool IsMarried { get; set; }
        
        [Required(ErrorMessage = "ورود شماره موبایل اجباری است"), MinLength(10, ErrorMessage ="لطفا شماره موبایل را کامل وارد نمایید")]
        public string TheMobileNumber { get; set; }

        public string? NeededMoneyToAttendInChallenge { get; set; }
        


    }
}
