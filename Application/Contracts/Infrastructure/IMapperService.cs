using Domain.Dtos;
using Domain.Entities;
using Domain.References;

namespace Application.Contracts.Infrastructure
{
    public interface IMapperService
    {
        public CustomerBasic ConvertCustomerToCustomerBasic(Customer customer);
        public Order ConvertOrderRequestToOrder(OrderRequest orderRequest);
        public OrderDetail ConvertOrderRequestToOrderDetail(OrderRequest orderRequest);
    }
}
