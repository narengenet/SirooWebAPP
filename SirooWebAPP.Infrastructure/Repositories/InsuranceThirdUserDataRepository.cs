﻿using SirooWebAPP.Application.Interfaces;
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
    public class InsuranceThirdUserDataRepository : GenericRepository<InsuranceThirdUserData>, IInsuranceThirdUserDataRepository
    {
        public InsuranceThirdUserDataRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}