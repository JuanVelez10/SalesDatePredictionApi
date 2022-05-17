using Domain.Entities;


namespace Application.Contracts.Persistence
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetail> GetOrdersForOrderId(int id);
    }
}
