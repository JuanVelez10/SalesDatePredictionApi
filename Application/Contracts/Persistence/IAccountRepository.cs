using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    public interface IAccountRepository
    {
        Account Get(Guid? id);
        List<Account> GetAll();
    }
}
