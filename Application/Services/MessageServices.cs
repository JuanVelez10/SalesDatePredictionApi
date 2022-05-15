using Application.Contracts.Persistence;
using Application.Interfaces;
using static Domain.Enums.Enums;

namespace Application.Services
{
    public class MessageServices : IMessageServices
    {
        private readonly IMessageRepository messageRepository;

        public MessageServices(IMessageRepository messageRepository)
        {
            this.messageRepository = messageRepository;
        }

        //Method to get success or error messages from database
        public string GetMessage(int Code, MessageType messageType)
        {
            return messageRepository.GetAll().Where(x => x.Code == Code && x.MessageType == (int)messageType).Select(x => x.Message1).FirstOrDefault();
        }

    }
}
