using Api.Controllers;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    public class Tests
    {
        private OrderController orderController;

        [SetUp]
        public void Setup()
        {
            var mockRepo = new Mock<IOrderServices>();
            mockRepo.Setup(repo => repo.GetOrdersForCustomerId(3,true)).Returns(Get());
            orderController = new OrderController(mockRepo.Object);
        }

        [Test]
        public async Task GetAllSucces()
        {
            Assert.IsTrue(orderController.Get(3).Wait(60000));
            var reponse = await orderController.Get(3) as OkObjectResult;
            Assert.IsNotNull(reponse);
            Assert.AreEqual(200, reponse.StatusCode);
            var orders = reponse.Value as List<Order>;
            Assert.IsTrue(orders.Any());
            orders.ForEach(x => Assert.IsNotNull(x));
            orders.ForEach(x => Assert.IsNotNull(x.Orderid));
        }

        [Test]
        public async Task GetError()
        {
            var reponseNotFound = await orderController.Get(0) as NotFoundObjectResult;
            Assert.IsNotNull(reponseNotFound);
            Assert.AreEqual(404, reponseNotFound.StatusCode);
        }


        private async Task<List<Order>> Get()
        {
            List<Order> orders = new List<Order>();
            Order order = new Order();
            order.Orderid = 3;
            orders.Add(order);
            return orders;
        }

    }
}