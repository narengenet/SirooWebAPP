using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Infrastructure.Contexts;
using SirooWebAPP.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<Users>, IUsersRepository
    {        
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

    }
    //public class UserRepository : IUsersRepository
    //{

    //    private readonly AppDbContext _context;
    //    List<Users> _users;

    //    public UserRepository(AppDbContext context)
    //    {
    //        _context = context;
    //        _users= context.Users.ToList<Users>();
    //    }
    //    public UserRepository()
    //    {

    //    }

    //    public List<Users> GetAllUsers()
    //    {

    //        return _users;

    //    }
    //    public Users GetUser(int id)
    //    {
    //        return _users.FirstOrDefault(u => u.ID == id);
    //    }
    //    public Users GetUserByUsername(string username)
    //    {
    //        return _users.FirstOrDefault(u => u.Username == username);
    //    }
    //    public Users GetUserByCellphone(string cellphone)
    //    {
    //        return _users.FirstOrDefault(u => u.Cellphone == cellphone);
    //    }
    //    public List<Users> GetUsers(int pageNumber = 1)
    //    {
    //        int pageSize = 2;
    //        int skip = pageSize * (pageNumber - 1);
    //        if (_users.Count < pageSize)
    //            pageSize = _users.Count;
    //        return _users
    //          .Skip(skip)
    //          .Take(pageSize).ToList();
    //    }
    //    public int Save(Users user)
    //    {
    //        var result = _users.Where(u => u.ID == user.ID);
    //        if (result != null)
    //        {
    //            if (result.Count() == 0)
    //            {
    //                //_users.Add(user);
    //                _context.Users.Add(user);
    //                _context.SaveChanges();
    //                return user.ID;
    //            }
    //        }
    //        return -1;
    //    }
    //    public bool Update(Users user)
    //    {
    //        Users result = GetUser(user.ID);
    //        if (result!=null)
    //        {
    //            _context.Users.Update(user);
    //            _context.SaveChanges();
    //            return true;
    //        }
    //        return false;

    //    }


    //}
}




//public class AuthorRepository
//{
//    List<Author> authors = new List<Author>()
//        {
//            new Author
//            {
//                Id = 1,
//                FirstName = "Joydip",
//                LastName = "Kanjilal"
//            },
//            new Author
//            {
//                Id = 2,
//                FirstName = "Steve",
//                LastName = "Smith"
//            }
//        };
//    public Author GetAuthor(int id)
//    {
//        return authors.FirstOrDefault(a => a.Id == id);
//    }
//    public List<Author> GetAuthors(int pageNumber = 1)
//    {
//        int pageSize = 10;
//        int skip = pageSize * (pageNumber - 1);
//        if (authors.Count < pageSize)
//            pageSize = authors.Count;
//        return authors
//          .Skip(skip)
//          .Take(pageSize).ToList();
//    }
//    public bool Save(Author author)
//    {
//        var result = authors.Where(a => a.Id == author.Id);
//        if (result != null)
//        {
//            if (result.Count() == 0)
//            {
//                authors.Add(author);
//                return true;
//            }
//        }
//        return false;
//    }
//}
