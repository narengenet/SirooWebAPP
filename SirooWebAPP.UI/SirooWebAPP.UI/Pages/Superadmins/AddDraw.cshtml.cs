using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class AddDrawModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public AddDrawModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        //public List<SelectListItem> Options { get; set; }
        //public List<SelectListItem> UserOptions { get; set; }

        [BindProperty]
        public AddDraw? AddDraw { get; set; }
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

        public IActionResult OnPostAddDraw(AddDraw addDraw)
        {
            if (ModelState.IsValid)
            {
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                DateTime startD = HelperFunctions.JavaTimeStampToDateTime(Convert.ToDouble(addDraw.StartDate));
                DateTime endD = HelperFunctions.JavaTimeStampToDateTime(Convert.ToDouble(addDraw.EndDate));
                if (endD>startD)
                {
                    Draws _d = _usersServices.GetAllDraws().Where(d => d.Name == addDraw.Name).FirstOrDefault<Draws>();
                    if (_d == null)
                    {
                        Draws draw = new Draws
                        {
                            CreatedBy = creatorID,
                            Created = DateTime.Now,
                            IsActivated = addDraw.IsActivated,
                            Name = addDraw.Name,
                            StartDate = startD,
                            EndDate = endD,
                            IsLottery = addDraw.IsLottery
                        };
                        _usersServices.AddDraw(draw);
                        ResultMessage = "دوره جدید ایحاد شد.";
                    }
                    else
                    {
                        ResultMessage = "دوره با این نام قبلا ایجاد شده است.";
                    }
                }
                else
                {
                    ResultMessage = "زمان شروع باید قبل از زمان انتهای دوره باشد.";
                }


            }

            return Page();

        }
    }
}
