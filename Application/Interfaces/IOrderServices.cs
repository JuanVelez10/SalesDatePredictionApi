using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderServices
    {
        public Task<List<Order>> GetOrdersForCustomerId(int Custid);
    }
}
