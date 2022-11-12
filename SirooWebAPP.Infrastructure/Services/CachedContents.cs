using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Core.Domain;

namespace SirooWebAPP.Infrastructure.Services
{
    public class CachedContents
    {
        //private readonly IUsersRepository _userRepo;
        //private readonly IAdverticeRepository _adverticeRepo;
        public static List<Advertise> Advertises = new List<Advertise>();
        public static List<Likers> Likers = new List<Likers>();
        public static List<Viewers> Viewers = new List<Viewers>();
    //    public CachedContents(IUsersRepository userRepo, IAdverticeRepository adverticeRepo)
    //    {
    //        _userRepo = userRepo;
    //        _adverticeRepo = adverticeRepo;
    //    }

    //    public static List<Advertise> GetAds()
    //    {
    //        // get all ads if owner quota is not ended and ads is not expired
    //        List<Advertise> result = _adverticeRepo.GetAll().Where(a => a.RemainedViewQuota != -1 && a.Expiracy <= DateTime.Now && a.IsAvtivated && a.IsDeleted == false && a.IsRejected == false)
    //            .Join(
    //                _userRepo.GetAll().Where(u => u.IsActivated == true && u.IsDeleted == false).ToList<Users>(),
    //                ads => ads.Owner,
    //                users => users.Id,
    //                (ads, users) => ads
    //                //new Advertise { Id=ads.Id, Name=ads.Name, Owner=ads.Owner, Caption=ads.Caption, Created=ads.Created, CreatedBy=ads.CreatedBy, CreationDate=ads.CreationDate, Expiracy=ads.Expiracy, IsAvtivated=ads.IsAvtivated, IsDeleted=ads.IsDeleted, IsSpecial=ads.IsSpecial, IsVideo=ads.IsVideo, LastModified=ads.LastModified, LastModifiedBy=ads.LastModifiedBy, LikeReward=ads.LikeReward, MediaSourceURL=ads.MediaSourceURL, RemainedViewQuota=ads.RemainedViewQuota, ViewQuota=ads.ViewQuota, ViewReward=ads.ViewReward}
    //            )
    //            .OrderByDescending(l => l.CreationDate)
    //            .ToList<Advertise>();
    //        return result;
    //    }
    }
}