using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SirooWebAPP.UI.Pages
{
    //public class MyStringLengthAttribute : StringLengthAttribute
    //{
    //    public MyStringLengthAttribute(int maximumLength)
    //        : base(maximumLength)
    //    {
    //    }

    //    public override bool IsValid(object value)
    //    {
    //        string val = Convert.ToString(value);
    //        if (val.Length < base.MinimumLength)
    //            base.ErrorMessage = "حداقل "+base.MinimumLength+" کاراکتر";
    //        if (val.Length > base.MaximumLength)
    //            base.ErrorMessage = "حداکثر "+base.MaximumLength+" کاراکتر";
    //        return base.IsValid(value);
    //    }
    //}
    public class LoginConfirmed
    {
        [Required]
        public Guid UserID { get; set; }
        //[MyStringLength(50, MinimumLength = 5)]

        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "کلمه عبور باید حداقل 6 کاراکتر باشد.")]
        [DataType(DataType.Password)]
        public string ConfirmationCode { get; set; }

        //[Required(ErrorMessage = "rePassword is required.")]
        //[StringLength(40, MinimumLength = 6, ErrorMessage = "کلمه عبور باید حداقل 6 کاراکتر باشد.")]
        //[Compare("ConfirmationCode", ErrorMessage = "تکرارکلمه عبور و کلمه عبور باید یکسان باشند.")]
        //[DataType(DataType.Password)]
        //public string reConfirmationCode { get; set; }






    }
}