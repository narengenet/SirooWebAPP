using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.DTO
{
    public class DTOPrize
    {
        public Guid PrizeId { get; set; }
        public string Name { get; set; }
        public Guid Draw { get; set; }
        public int WinnerCount { get; set; }
        public int Priority { get; set; }
        public Guid CreatedBy { get; set; }
        public bool IsActivated { get; set; }
    }
}
