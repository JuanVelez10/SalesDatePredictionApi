using Domain.Entities;


namespace Application.Contracts.Persistence
{
    public interface IShipperRepository
    {
        public List<Shipper> GetAll();
    }
}
