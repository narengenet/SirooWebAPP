using Microsoft.AspNetCore.SignalR;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using System.Text.Json;

namespace SirooWebAPP.UI.Hubs
{
    public class ChatHub : Hub
    {

        private readonly IUserServices _usersServices;

        public ChatHub(IUserServices userServices)
        {
            _usersServices = userServices;
        }
        public async Task SendMessage(string user, string message)
        {
            Users result = _usersServices.GetUser(Guid.Parse("5173159E-B9B4-4A5A-0BC1-08DAA3353D12"));

            string txt = result.Username;

            await Clients.All.SendAsync("ReceiveMessage", user, txt);
        }
        public async Task SendUser(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
