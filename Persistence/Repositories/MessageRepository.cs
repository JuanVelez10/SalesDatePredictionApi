using Application.Contracts.Persistence;
using Domain.Entities;
using Domain.Persistence.DataBase;

namespace Persistence.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly StoreSampleContext dbContext;

        public MessageRepository(StoreSampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Message> GetAll()
        {
            return dbContext.Messages.ToList();
        }

    }
}
