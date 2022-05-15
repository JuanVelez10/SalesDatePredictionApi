using Application.Contracts.Infrastructure;
using AutoMapper;
using Domain.Dtos;
using Domain.Entities;


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

    }
}
