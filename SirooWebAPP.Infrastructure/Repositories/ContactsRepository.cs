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
    public class ContactsRepository : GenericRepository<Contacts>, IContactsRepository
    {
        public ContactsRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}