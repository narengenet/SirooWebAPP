using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Application.DTO
{
    public class DTOUserSmallProfile
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string ProfileMediaURL { get; set; }
        public bool AmIFollowUser { get; set; }
        public bool IsMe { get; set; }

    }
}
