using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OrderServices: IOrderServices
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderDetailServices orderDetailServices;

        public OrderServices(IOrderRepository orderRepository, IOrderDetailServices orderDetailServices)
        {
            this.orderRepository = orderRepository;
            this.orderDetailServices = orderDetailServices;
        }

        public async Task<List<Order>> GetOrdersForCustomerId(int Custid,bool withDetails=false)
        {
            var orders = orderRepository.GetOrdersForCustomerId(Custid);

            if (withDetails)
            {
                if (orders.Any())
                {
                    foreach (var order in orders)
                    {
                        order.OrderDetails = await orderDetailServices.GetOrdersForOrderId(order.Orderid);
                    }
                }
            }
 
            return orders;
        }

    }
}
