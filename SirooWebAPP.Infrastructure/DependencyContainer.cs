using Microsoft.Extensions.DependencyInjection;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Repositories;
using SirooWebAPP.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Infrastructure
{
    public static class DependencyContainer
    {
        public static void AddIoCService(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UserRepository>();
            services.AddScoped<IOnlineUsersRepository, OnlineUsersRepository>();
            services.AddScoped<IAdverticeRepository, AdvertiseRepository>();
            services.AddScoped<ILikersRepository, LikersRepository>();
            services.AddScoped<IViewersRepository, ViewersRepository>();
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<IUsersRolesRepository, UsersRolesRepository>();
            services.AddScoped<IDrawsRepository, DrawsRepository>();
            services.AddScoped<IPrizesRepository, PrizesRepository>();
            services.AddScoped<IConstantDictionariesRepository, ConstantDictionariesRepository>();
            services.AddScoped<IPointUsagesRepository, PointUsagesRepository>();
            services.AddScoped<IDonnationTickets, DonnationTicketsRepository>();
            services.AddScoped<IPrizesWinnersRepository, PrizesWinnersRepository>();
            services.AddScoped<ITransactionsRepository, TransactionsRepository>();
            services.AddScoped<IPurchasesRepository, PurchasesRepository>();
            services.AddScoped<ITransactionPercentsRepository, TransactionPercentsRepository>();

            services.AddScoped<IUserServices, UsersServices>();
        }
    }
}
