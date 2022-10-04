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
    public class AdvertiseRepository : GenericRepository<Advertise>, IAdverticeRepository
    {
        public AdvertiseRepository(AppDbContext dbContext) : base(dbContext)
        {


        }
        //private readonly AppDbContext _context;
        //List<OnlineUsers> _onlineUsers;


        //public AdvertiseRepository(AppDbContext context)
        //{
        //    _context = context;
        //    _onlineUsers = context.OnlineUsers.ToList<OnlineUsers>();
        //}
        //public bool AddViewerToAdvertise(Users users, Advertise advertise)
        //{

        //    return Update(advertise);
        //}

        //public Advertise GetAdvertise(Int64 advertiseID)
        //{
        //    return _context.Advertises.FirstOrDefault(a => a.AdvertiseID == advertiseID);
        //}

        //public List<Advertise> GetAllAdvertises()
        //{
        //    return _context.Advertises.ToList<Advertise>();
        //}

        //public bool UpdateAdvertise(Advertise advertise)
        //{
        //    Advertise result = GetAdvertise(advertise.AdvertiseID);
        //    if (result != null)
        //    {
        //        _context.Advertises.Update(advertise);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}



        //public long Save(Advertise advertise)
        //{
        //    var result = _context.Advertises.Where(a => a.AdvertiseID == advertise.AdvertiseID);
        //    if (result != null)
        //    {
        //        if (result.Count() == 0)
        //        {
        //            //_users.Add(user);
        //            _context.Advertises.Add(advertise);
        //            _context.SaveChanges();
        //            return advertise.AdvertiseID;
        //        }
        //    }
        //    return -1;
        //}
        //public bool Update(Advertise advertise)
        //{
        //    Advertise result = GetAdvertise(advertise.AdvertiseID);
        //    if (result != null)
        //    {
        //        _context.Advertises.Update(advertise);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    return false;

        //}

    }
}
