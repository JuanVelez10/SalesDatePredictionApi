using Domain.Entities;


namespace Application.Interfaces
{
    public interface IProductServices
    {
        public Task<Product> Get(int id);
        public Task<List<Product>> GetAll();

    }
}
