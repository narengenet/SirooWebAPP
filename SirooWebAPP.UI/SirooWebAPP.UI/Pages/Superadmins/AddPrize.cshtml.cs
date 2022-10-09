using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Helpers;

namespace SirooWebAPP.UI.Pages.Superadmins
{
    public class AddPrizeModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public AddPrizeModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        public List<SelectListItem> DrawsOptions { get; set; }
        //public List<SelectListItem> UserOptions { get; set; }

        [BindProperty]
        public AddPrize? AddPrize { get; set; }


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
            DrawsOptions = _usersServices.GetAllDraws().Where(d => d.IsActivated == true && d.IsDeleted == false).Select(a =>
                new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                }
            ).ToList();
        }

        public List<string>? ResultMessage = new List<string>();

        public IActionResult OnPostAddPrize(AddPrize addPrize)
        {
            if (ModelState.IsValid)
            {
                bool permit = true;
                List<Prizes> _prizes = _usersServices.GetAllPrizes().Where(p => p.Draw == addPrize.DrawId && p.IsDeleted == false).ToList<Prizes>();

                if (_prizes.Where(p => p.Name == addPrize.Name).ToList<Prizes>().Count > 0)
                {
                    permit = false;
                    ResultMessage.Add("قبلا با این نام جایزه برای این دوره تعیین شده است. لطفا نام دیگری استفاده نمایید.");
                }
                if (_prizes.Where(p => p.Priority == addPrize.Priority).ToList<Prizes>().Count > 0)
                {
                    permit = false;
                    ResultMessage.Add("قبلا با این اولویت جایزه تایین شده است. لطفا از اولویت بالاتر استفاده نمایید.");
                }



                if (permit)
                {
                    string _creatorId = HelperFunctions.GetCookie("userid", Request);
                    Guid creatorID = Guid.Parse(_creatorId);
                    Prizes _p = new Prizes
                    {
                        Created = DateTime.Now,
                        CreatedBy = creatorID,
                        Draw = addPrize.DrawId,
                        WinnerCount = addPrize.WinnerCount,
                        Priority = addPrize.Priority,
                        Name = addPrize.Name,
                        IsActivated = addPrize.IsActivated
                    };
                    _usersServices.AddPrize(_p);
                    ResultMessage.Add("جایزه اضافه شد");
                }


            }


            DrawsOptions = _usersServices.GetAllDraws().Where(d => d.IsActivated == true && d.IsDeleted == false).Select(a =>
                new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                }
            ).ToList();
            return Page();

        }

    }
}
