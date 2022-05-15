using Application.Contracts.Persistence;
using Domain.Entities;
using Domain.Persistence.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly StoreSampleContext dbContext;

        public CustomerRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Customer> GetAll()
        {
            return dbContext.Customers.ToList();
        }
    }
}
