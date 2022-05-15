using Application.Contracts.Infrastructure;
using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IMessageServices messageServices;
        private readonly IMapperService mapper;

        public CustomerServices(ICustomerRepository customerRepository, IMessageServices messageServices, IMapperService mapper)
        {
            this.customerRepository = customerRepository;
            this.messageServices = messageServices;
            this.mapper = mapper;
        }


        public async Task<List<CustomerBasic>> GetAllCustomerBasic(string name)
        {
            var customers = customerRepository.GetAll();
            if (!string.IsNullOrEmpty(name)) customers = customers.Where(x => x.Contactname.Contains(name)).ToList();
            var customers_basic = customers.Select(x=> mapper.ConvertCustomerToCustomerBasic(x)).ToList();

            if (customers_basic.Any())
            {
                foreach (var customer_basic in customers_basic)
                {
                    //var person = personService.GetOrdesForId(customer_basic.PersonId);
                    //if (person != null) billBasic.NameClient = person.Result.Name;
                }
            }

            return customers_basic;
        }



    }
}
