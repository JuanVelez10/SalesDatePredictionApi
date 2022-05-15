using Application.Contracts.Persistence;
using Domain.Entities;
using Domain.Persistence.DataBase;

namespace Persistence.Repositories
{
    public class AccountRepository : IAccountRepository
    {

        private readonly StoreSampleContext dbContext;

        public AccountRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Account Get(Guid? id)
        {
            return dbContext.Accounts.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Account> GetAll()
        {
            return dbContext.Accounts.ToList();
        }

    }
}
