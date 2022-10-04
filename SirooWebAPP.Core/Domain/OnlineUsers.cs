using Microsoft.EntityFrameworkCore;
using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{

    public class OnlineUsers : AuditableBaseEntity
    {


        public Guid User { get; set; }
        public String Guid { get; set; }
        public DateTime LastCheckin { get; set; }
        public string UserDevice { get; set; }


        public OnlineUsers()
        {

        }
    }
}
