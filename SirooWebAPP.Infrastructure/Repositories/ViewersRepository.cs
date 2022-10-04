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
    public class ViewersRepository : GenericRepository<Viewers>, IViewersRepository
    {
        public ViewersRepository(AppDbContext dbContext) : base(dbContext)
        {


        }
        //private readonly AppDbContext _context;
        //List<Viewers> _viewers;
        //public ViewersRepository(AppDbContext context)
        //{
        //    _context = context;
        //    _viewers = context.Viewers.ToList<Viewers>();
        //}
        //public long AddView(Advertise advertise, Users users)
        //{
        //    var result = _context.Viewers.Where(l => l.Advertise.AdvertiseID == advertise.AdvertiseID && l.ViewedBy.Id == users.Id);
        //    if (result != null)
        //    {
        //        if (result.Count() == 0)
        //        {
        //            //_users.Add(user);
        //            Viewers _liker = new Viewers { Advertise = advertise, ViewedBy = users };
        //            _context.Viewers.Add(_liker);
        //            _context.SaveChanges();
        //            return _liker.ID;
        //        }
        //    }
        //    return -1;
        //}

        //public List<Viewers> GetViewedAdvertisesByUserID(Users users)
        //{
        //    return _context.Viewers.Where(l => l.ViewedBy.Id == users.Id).ToList<Viewers>();
        //}

        //public Viewers GetViewes(long id)
        //{
        //    return _context.Viewers.FirstOrDefault(v => v.ID==id);
        //}

        //public List<Viewers> GetViews(Advertise advertise)
        //{
        //    return _context.Viewers.Where(l => l.Advertise.AdvertiseID == advertise.AdvertiseID).ToList<Viewers>();
        //}

        //public bool RemoveView(Advertise advertise, Users users)
        //{
        //    throw new NotImplementedException();
        //}

        //public long Save(Viewers viewers)
        //{
        //    var result = _context.Viewers.Where(l => l.ID == viewers.ID);
        //    if (result != null)
        //    {
        //        if (result.Count() == 0)
        //        {
        //            //_users.Add(user);
        //            _context.Viewers.Add(viewers);
        //            _context.SaveChanges();
        //            return viewers.ID;
        //        }
        //    }
        //    return -1;
        //}

        //public bool Update(Viewers viewers)
        //{
        //    Viewers result = GetViewes(viewers.ID);
        //    if (result != null)
        //    {
        //        _context.Viewers.Update(viewers);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    return false;

        //}
    }
}
