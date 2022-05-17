using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class OrderDetailServices: IOrderDetailServices
    {

        private readonly IOrderDetailRepository orderDetailRepository;
        private readonly IProductServices productServices;

        public OrderDetailServices(IOrderDetailRepository orderDetailRepository, IProductServices productServices)
        {
            this.orderDetailRepository = orderDetailRepository;
            this.productServices = productServices;
        }

        public async Task<List<OrderDetail>> GetOrdersForOrderId(int id)
        {
            var details = orderDetailRepository.GetOrdersForOrderId(id);
            if (details.Any())
            {
                foreach (var detail in details)
                {
                    detail.Product = await productServices.Get(detail.Productid);
                }

            }
            return details;
        }

    }
}
