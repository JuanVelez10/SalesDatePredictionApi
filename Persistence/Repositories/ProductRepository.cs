using Application.Contracts.Persistence;
using Domain.Entities;
using Domain.Persistence.DataBase;

namespace Persistence.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly StoreSampleContext dbContext;

        public ProductRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Product Get(int id)
        {
            return dbContext.Products.Where(x => x.Productid == id).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }
    }
}
