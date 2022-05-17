using Application.Contracts.Persistence;
using Domain.Entities;
using Domain.Persistence.DataBase;


namespace Persistence.Repositories
{
    public class OrderDetailRepository: IOrderDetailRepository
    {
        private readonly StoreSampleContext dbContext;

        public OrderDetailRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<OrderDetail> GetOrdersForOrderId(int id)
        {
            return dbContext.OrderDetails.Where(x => x.Orderid == id).ToList();
        }
    }
}
