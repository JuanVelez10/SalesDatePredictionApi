using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services
               .AddTransient<IAccountServices, AccountServices>()
               .AddTransient<IMessageServices, MessageServices>()
               .AddTransient<ICustomerServices, CustomerServices>()
               .AddTransient<IOrderServices, OrderServices>()
               .AddTransient<IOrderDetailServices, OrderDetailServices>()
               .AddTransient<IProductServices, ProductServices>()
               .AddTransient<IEmployeeServices, EmployeeServices>()
               .AddTransient<IShipperServices, ShipperServices>();
             
            return services;
        }

    }
}
