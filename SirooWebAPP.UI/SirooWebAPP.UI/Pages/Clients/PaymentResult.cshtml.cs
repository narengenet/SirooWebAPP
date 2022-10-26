using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SirooWebAPP.UI.Pages.Clients
{
    public class PaymentResultModel : PageModel
    {
        [BindProperty(Name = "RefId", SupportsGet = true)]
        public string? RefId { get; set; }
        [BindProperty(Name = "Code", SupportsGet = true)]
        public string? Code { get; set; }
        [BindProperty(Name = "Status", SupportsGet = true)]
        public bool? Status { get; set; }



        public string ResultMessage = "";
        public string ResultMessageSuccess = "danger";
        public void OnGet()
        {
        }
        public void OnGetDisplay()
        {


            RefId = RefId.Replace("A00000000000000000000000000", "");
            

            if (Status==true)
            {

                ResultMessageSuccess = "success";
                ResultMessage = "پرداخت موفقیت آمیز بود. کد پیگیری:" + RefId;
            }
            else
            {
                ResultMessage = "خطا در پرداخت. کد پیگیری: " + RefId;
            }

        }
    }
}
