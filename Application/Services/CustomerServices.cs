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

        public CustomerServices(ICustomerRepository accountRepository, IMessageServices messageServices)
        {
            this.customerRepository = accountRepository;
            this.messageServices = messageServices;
        }


        public List<CustomerBasic> GetAllCustomerBasic()
        {
            throw new NotImplementedException();
        }
    }
}
