using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.QrCode;
using SirooWebAPP.UI.Helpers;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.UI.ViewModels;

namespace SirooWebAPP.UI.Pages.Stores
{
    public class DashboardModel : PageModel
    {
        private readonly IUserServices _usersServices;
        private readonly CustomIDataProtection protector;
        private IWebHostEnvironment _environment;


        public DashboardModel(CustomIDataProtection customIDataProtection, IUserServices services, IWebHostEnvironment environment)
        {
            _usersServices = services;
            protector = customIDataProtection;
            _environment = environment;

        }

        [BindProperty]
        public AddQRModel? AddQRModel { get; set; }

        public List<TicketsModel> QrCodes = new List<TicketsModel>();
        public void OnGet()
        {
            PrepareQRs();
        }

        public string? ResultMessage = "";
        public string ResultMessageSuccess = "danger";

        public IActionResult OnPostAddQR(AddQRModel addQRModel)
        {



            if (ModelState.IsValid)
            {
                string _creatorId = HelperFunctions.GetCookie("userid", Request);
                Guid creatorID = Guid.Parse(_creatorId);
                Roles role = _usersServices.GetUserRoles(creatorID).OrderBy(u => u.Priority).First();
                if (role != null)
                {
                    if (role.RoleName == "store")
                    {
                        DonnationTickets _ticket = new DonnationTickets
                        {
                            IsCredit = false,
                            Donner = creatorID,
                            Value = addQRModel.Points,
                            Created = DateTime.Now,
                            RemainedCapacity = addQRModel.Capacity
                        };
                        _usersServices.AddDonnationTicket(_ticket);
                        ResultMessage = "QR شما با موفقیت ایجاد شد.";
                        ResultMessageSuccess = "success";
                    }
                    else
                    {
                        ResultMessage = "فقط کاربر با نقش فروشگاه میتواند QR تولید کند.";
                    }
                }
                else
                {
                    ResultMessage = "شما هیچ نقش تعیین شده ای ندارید.";
                }

            }

            PrepareQRs();
            return Page();
        }

        private void PrepareQRs()
        {
            string _creatorId = HelperFunctions.GetCookie("userid", Request);
            Guid creatorID = Guid.Parse(_creatorId);
            List<DonnationTickets> tickets = _usersServices.GetAllDonnationTickets().Where(t => t.Donner == creatorID && t.RemainedCapacity > 0).ToList<DonnationTickets>();
            foreach (DonnationTickets item in tickets)
            {
                string qrText = HelperFunctions.CreateQR("https://localhost:7051/Public/AddPoints?ticket=" + item.Id.ToString());
                TicketsModel _t = new TicketsModel { QRsrc = qrText, Capacity = item.RemainedCapacity, Val = item.Value, TicketURL = "https://localhost:7051/Public/AddPoints?ticket=" + item.Id.ToString() };
                QrCodes.Add(_t);
            }
        }
    }
}
