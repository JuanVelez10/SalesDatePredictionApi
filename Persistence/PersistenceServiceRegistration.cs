﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
           // services.AddDbContext<StoreSampleFirstContext>(options => options.UseSqlServer(configuration.GetConnectionString("StoreSample"), b => b.MigrationsAssembly("Api")));

            return services;
        }

    }
}
