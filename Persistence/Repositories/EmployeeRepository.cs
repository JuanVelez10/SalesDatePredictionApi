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
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly StoreSampleContext dbContext;

        public EmployeeRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Employee> GetAll()
        {
            return dbContext.Employees.ToList();
        }

    }
}
