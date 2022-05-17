using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ShipperServices: IShipperServices
    {
        private readonly IShipperRepository shipperRepository;

        public ShipperServices(IShipperRepository shipperRepository)
        {
            this.shipperRepository = shipperRepository;
        }

        public async Task<List<Shipper>> GetAll()
        {
            return shipperRepository.GetAll();
        }
    }
}
