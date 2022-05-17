using Domain.Entities;
using Domain.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderServices
    {
        public Task<List<Order>> GetOrdersForCustomerId(int Custid, bool withDetails=false);
        Task<BaseResponse<bool>> Insert(OrderRequest order);
    }
}
