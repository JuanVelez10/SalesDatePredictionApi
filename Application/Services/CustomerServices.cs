using Application.Contracts.Infrastructure;
using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Dtos;
using Utilities;

namespace Application.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IMapperService mapper;
        private readonly IOrderServices orderServices;

        public CustomerServices(ICustomerRepository customerRepository, IMapperService mapper, IOrderServices orderServices)
        {
            this.customerRepository = customerRepository;
            this.mapper = mapper;
            this.orderServices = orderServices;
        }


        public async Task<List<CustomerBasic>> GetAllCustomerBasic(string name)
        {
            var customers_basic = customerRepository.GetAll().Select(x => mapper.ConvertCustomerToCustomerBasic(x)).ToList();
            if (!string.IsNullOrEmpty(name)) customers_basic = customers_basic.Where(x => x.Companyname.Contains(name)).ToList();
            if (!customers_basic.Any()) return customers_basic;

            foreach (var customer_basic in customers_basic)
            {
                var orders = await orderServices.GetOrdersForCustomerId(customer_basic.Custid);
                if (orders.Any())
                {
                    var ordersDate = orders.OrderBy(x => x.Orderdate).Select(x => x.Orderdate).ToList();
                    customer_basic.LastOrderDate = ordersDate.Last();
                    customer_basic.NextPredictedOrderDate = Util.GetNextPredictedOrderDate(ordersDate);
                }
            }

            return customers_basic;
        }



    }
}
