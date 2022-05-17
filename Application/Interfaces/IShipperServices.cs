using Domain.Entities;

namespace Application.Interfaces
{
    public interface IShipperServices
    {
        public Task<List<Shipper>> GetAll();
    }
}
