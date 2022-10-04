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
    public class LikersRepository : GenericRepository<Likers>, ILikersRepository
    {
        public LikersRepository(AppDbContext dbContext) : base(dbContext)
        {


        }
        //private readonly AppDbContext _context;
        //List<Likers> _likers;


        //public LikersRepository(AppDbContext context)
        //{
        //    _context = context;
        //    _likers = context.Likers.ToList<Likers>();
        //}
        //public Guid? AddLike(Advertise advertise, Users users)
        //{
        //    // find if previously this user liked current ads or not
        //    var result = _context.Likers
        //        .Where(l => l.Advertise.AdvertiseID == advertise.AdvertiseID && l.LikedBy.Id==users.Id);
        //    if (result != null)
        //    {
        //        if (result.Count() == 0)
        //        {
        //            // create liker record by ads and user data
        //            Likers _liker = new Likers { Advertise = advertise, LikedBy = users };
        //            _context.Likers.Add(_liker);
        //            _context.SaveChanges();
        //            return _liker.Id;
        //        }
        //    }
        //    return null;
        //}

        //List<Likers> ILikersRepository.GetLikedAdvertisesByUserID(Users users)
        //{
        //    return _context.Likers.Where(l => l.LikedBy.Id == users.Id).ToList<Likers>();

        //}

        //public List<Likers> GetLikes(Advertise advertise)
        //{
        //    return _context.Likers.Where(l => l.Advertise.AdvertiseID== advertise.AdvertiseID).ToList<Likers>();
        //}

        //bool ILikersRepository.RemoveLike(Advertise advertise, Users users)
        //{
        //    throw new NotImplementedException();
        //}


        //public Guid? Save(Likers likers)
        //{
        //    var result = _context.Likers.Where(l => l.Id == likers.Id);
        //    if (result != null)
        //    {
        //        if (result.Count() == 0)
        //        {
        //            //_users.Add(user);
        //            _context.Likers.Add(likers);
        //            _context.SaveChanges();
        //            return likers.Id;
        //        }
        //    }
        //    return null;
        //}
        //public Likers GetLiker(long id)
        //{
        //    return _context.Likers.FirstOrDefault(l => l.ID == id);
        //}
        //public bool Update(Likers likers)
        //{
        //    Likers result = GetLiker(likers.ID);
        //    if (result != null)
        //    {
        //        _context.Likers.Update(likers);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    return false;

    }
}
