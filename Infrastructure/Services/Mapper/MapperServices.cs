using Application.Contracts.Infrastructure;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.References;

namespace Infrastructure.Services.Mapper
{
    public class MapperServices : IMapperService
    {
        private readonly IMapper mapper;

        public MapperServices(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public CustomerBasic ConvertCustomerToCustomerBasic(Customer customer)
        {
            return mapper.Map<CustomerBasic>(customer);
        }

        public Order ConvertOrderRequestToOrder(OrderRequest orderRequest)
        {
            return mapper.Map<Order>(orderRequest);
        }

        public OrderDetail ConvertOrderRequestToOrderDetail(OrderRequest orderRequest)
        {
            return mapper.Map<OrderDetail>(orderRequest);
        }


    }
}
