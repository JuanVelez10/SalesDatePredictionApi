using Application.Contracts.Persistence;
using Domain.Entities;
using Domain.Persistence.DataBase;


namespace Persistence.Repositories
{
    public class ShipperRepository : IShipperRepository
    {
        private readonly StoreSampleContext dbContext;

        public ShipperRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Shipper> GetAll()
        {
            return dbContext.Shippers.ToList();
        }
    }
}
