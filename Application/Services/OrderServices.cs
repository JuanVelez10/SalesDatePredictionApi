using Application.Contracts.Infrastructure;
using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Entities;
using Domain.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.Enums;

namespace Application.Services
{
    public class OrderServices: IOrderServices
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderDetailServices orderDetailServices;
        private readonly IMessageServices messageServices;
        private readonly IMapperService mapper;

        public OrderServices(IOrderRepository orderRepository, IOrderDetailServices orderDetailServices, IMessageServices messageServices, IMapperService mapper)
        {
            this.orderRepository = orderRepository;
            this.orderDetailServices = orderDetailServices;
            this.messageServices = messageServices;
            this.mapper = mapper;
        }

        public async Task<List<Order>> GetOrdersForCustomerId(int Custid,bool withDetails=false)
        {
            var orders = orderRepository.GetOrdersForCustomerId(Custid);

            if (withDetails)
            {
                if (orders.Any())
                {
                    foreach (var order in orders)
                    {
                        order.OrderDetails = await orderDetailServices.GetOrdersForOrderId(order.Orderid);
                    }
                }
            }
 
            return orders;
        }

        public async Task<BaseResponse<bool>> Insert(OrderRequest order)
        {
            BaseResponse<bool> response = new BaseResponse<bool>();

            response = Validate(order);
            if (response.Code > 0) return response;

            var orderDB = mapper.ConvertOrderRequestToOrder(order);
            orderDB.OrderDetails.Add(mapper.ConvertOrderRequestToOrderDetail(order));
            var save = orderRepository.Insert(orderDB);

            if (!save) return MessageResponse(6, MessageType.Error);

            response = MessageResponse(1, MessageType.Success, "Order");
            response.Data = save;

            return response;
        }

        private BaseResponse<bool> Validate(OrderRequest order)
        {
            if (order.Empid <= 0) return MessageResponse(4, MessageType.Error, "Employee");
            if (order.Custid <= 0) return MessageResponse(4, MessageType.Error, "Customer");
            if (order.Productid <= 0) return MessageResponse(4, MessageType.Error, "Product");
            if (order.Shipperid <= 0) return MessageResponse(4, MessageType.Error, "Shipper");

            if (order.Orderdate == null) return MessageResponse(4, MessageType.Error, "Orderdate");
            if (order.Requireddate == null) return MessageResponse(4, MessageType.Error, "Requireddate");
            if (order.Shippeddate == null) return MessageResponse(4, MessageType.Error, "Shippeddate");

            if (order.Freight <= 0) return MessageResponse(4, MessageType.Error, "Freight");
            if (order.Unitprice <= 0) return MessageResponse(4, MessageType.Error, "Unitprice");
            if (order.Qty <= 0) return MessageResponse(4, MessageType.Error, "Qty");

            if (string.IsNullOrEmpty(order.Shipname)) return MessageResponse(4, MessageType.Error, "Shipname");
            if (string.IsNullOrEmpty(order.Shipaddress)) return MessageResponse(4, MessageType.Error, "Shipaddress");
            if (string.IsNullOrEmpty(order.Shipcity)) return MessageResponse(4, MessageType.Error, "Shipcity");
            if (string.IsNullOrEmpty(order.Shipcountry)) return MessageResponse(4, MessageType.Error, "Shipcountry");

            return new BaseResponse<bool>();

        }

        public BaseResponse<bool> MessageResponse(int code, MessageType messageType, string additionalMessage = "")
        {
            BaseResponse<bool> response = new BaseResponse<bool>();
            response.Code = code;
            response.Message = String.Format("{0} {1}", messageServices.GetMessage(code, messageType), additionalMessage);
            response.MessageType = messageType;
            return response;
        }

    }
}
