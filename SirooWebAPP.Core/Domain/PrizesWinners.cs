﻿using SirooWebAPP.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Core.Domain
{
    public class PrizesWinners : AuditableBaseEntity
    {
        public Prizes Prize { get; set; }
        public Users User { get; set; }
        public DateTime WiningDate { get; set; }
    }
}
