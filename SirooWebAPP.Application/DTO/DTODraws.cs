using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.DTO
{
    public class DTODraws
    {
        public Guid DrawId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Created { get; set; }
        public bool IsLottery { get; set; }
        public Guid CreatedBy { get; set; }
        public bool IsActivated { get; set; }
        public bool IsFinished { get; set; }
        public bool IsArchived { get; set; }
        public Guid OwnerId { get; set; }
        public DTOUser Owner { get; set; }
        public ICollection<DTOPrize> Prizes { get; set; }
        public ICollection<DTOUser> PrizeWinners { get; set; }

    }
}
