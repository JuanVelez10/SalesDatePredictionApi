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

        public bool Insert(Order order)
        {
            using (var dbContextTransaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    var details = order.OrderDetails;

                    var orderDb = dbContext.Orders.Add(order).Entity;

                    foreach (var detail in details)
                    {
                        detail.Orderid = orderDb.Orderid;
                        dbContext.OrderDetails.Add(detail);
                    }

                    dbContext.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }

        }

    }
}
