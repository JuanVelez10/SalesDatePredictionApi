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

        public OrderServices(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task<List<Order>> GetOrdersForCustomerId(int Custid)
        {
            return orderRepository.GetOrdersForCustomerId(Custid);
        }

    }
}
