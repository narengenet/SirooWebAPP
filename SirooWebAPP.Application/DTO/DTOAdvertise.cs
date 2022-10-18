using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.DTO
{
    public class DTOAdvertise
    {
        public Guid AdvertiseID { get; set; }
        public string? Notes { get; set; }
        public string Caption { get; set; }
        
        public string CreationDate { get; set; }
        public Users CreatedBy { get; set; }
        public DTOUser Owner { get; set; }
        public bool IsVideo { get; set; }
        public string MediaSourceURL { get; set; }
        public bool YouLiked { get; set; }
        public int LikerCount { get; set; }
        public int ViewerCount { get; set; }
        public int LikeReward { get; set; }
        public int ViewReward { get; set; }
        public bool IsRejected { get; set; }
        public bool IsAvtivated { get; set; }

        public ICollection<Likers>  Likers{ get; set; }
        public ICollection<Viewers> Viewers { get; set; }

    }
}
