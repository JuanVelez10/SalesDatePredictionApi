using Application.Contracts.Persistence;
using Domain.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StoreSampleContext>(options => options.UseSqlServer(configuration.GetConnectionString("StoreSample"), b => b.MigrationsAssembly("Api")));

            services
                    .AddTransient<IAccountRepository, AccountRepository>()
                    .AddTransient<IMessageRepository, MessageRepository>()
                    .AddTransient<ICustomerRepository, CustomerRepository>()
                    .AddTransient<IOrderRepository, OrderRepository>()
                    .AddTransient<IOrderDetailRepository, OrderDetailRepository>()
                    .AddTransient<IProductRepository, ProductRepository>()
                    .AddTransient<IEmployeeRepository, EmployeeRepository>()
                    .AddTransient<IShipperRepository, ShipperRepository>();
             
            return services;
        }

    }
}
