using Application.Contracts.Persistence;
using Domain.Entities;
using Domain.Persistence.DataBase;

namespace Persistence.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreSampleContext dbContext;

        public OrderRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Order> GetOrdersForCustomerId(int Custid)
        {
            return dbContext.Orders.Where(x=> x.Custid == Custid).ToList();
        }
    }
}
