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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsLottery { get; set; }
        public Users CreatedBy { get; set; }
        public bool IsActivated { get; set; }
        public bool IsFinished { get; set; }
        public ICollection<Prizes> Prizes { get; set; }
        public ICollection<Users> PrizeWinners { get; set; }

    }
}
