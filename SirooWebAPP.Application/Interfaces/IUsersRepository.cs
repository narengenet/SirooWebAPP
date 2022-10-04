using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.Interfaces
{
    public interface IUsersRepository :IGenericRepository<Users>
    {



    }
}
        //public interface IUsersRepository
        //{
        //    public List<Users> GetAllUsers();
        //    public Users GetUser(int id);
        //    public Users GetUserByUsername(string username);
        //    public Users GetUserByCellphone(string cellphone);
        //    public List<Users> GetUsers(int pageNumber = 1);
        //    public int Save(Users user);
        //    public bool Update(Users user);



        //}


