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
