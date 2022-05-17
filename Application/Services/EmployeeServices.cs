using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAll()
        {
            return employeeRepository.GetAll();
        }
    }
}
