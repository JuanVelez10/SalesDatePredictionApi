using Domain.Entities;


namespace Application.Contracts.Persistence
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
    }
}
