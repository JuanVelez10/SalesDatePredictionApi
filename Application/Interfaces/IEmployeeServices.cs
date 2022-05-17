using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEmployeeServices
    {
        public Task<List<Employee>> GetAll();
    }
}
