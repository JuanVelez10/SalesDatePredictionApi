using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.References;

namespace Infrastructure.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerBasic>();
            CreateMap<OrderRequest, Order>();
            CreateMap<OrderRequest, OrderDetail>();
        }

    }
}
