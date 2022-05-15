using Domain.Dtos;
using Domain.Entities;


namespace Application.Contracts.Infrastructure
{
    public interface IMapperService
    {
        public CustomerBasic ConvertCustomerToCustomerBasic(Customer customer);
    }
}
