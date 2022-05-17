using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IProductRepository
    {
        public Product Get(int id);
        public List<Product> GetAll();
    }
}
