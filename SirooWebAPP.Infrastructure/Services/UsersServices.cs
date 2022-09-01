using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Infrastructure.Services
{
    public class UsersServices : IUserServices
    {
        private readonly IUsersRepository _repo;

        public UsersServices(IUsersRepository repo)
        {
            _repo = repo;
        }
        public List<String> GetUsernames()
        {
            Users[] users = _repo.GetUsers();
            List<String> usernames = new List<string>();
            foreach (Users item in users)
            {
                usernames.Add(item.Username);
            }
            return usernames;

        }
        public string GetInviterUsername(int ID)
        {
            Users[] users = _repo.GetUsers();
            string result = "cannotfind";
            foreach (var item in users)
            {
                if (item!=null)
                {
                    if (item.Inviter!=null)
                    {
                        result = item.Inviter.Username;
                    }
                    
                }
            }
            return result;
        }
    }
}
