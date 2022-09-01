using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Infrastructure.Repositories
{
    public class UserRepository : IUsersRepository
    {
        public Users[] GetUsers()
        {
            var result = new List<Users>();
            Users sina = new Users { Name = "Sina", Family = "Sarparast", ID = 1, Cellphone = "09394125130", Username = "narengenet" };
            Users ali = new Users { Name = "Ali", Family = "Faraji", ID = 2, Cellphone = "09126714298", Inviter = sina, Username = "olay" };
            result.Add(sina);
            result.Add(ali);

            return result.ToArray<Users>();

        }
    }
}
