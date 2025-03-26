using Assignment5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void AddTest()
        {
            OrderService orderService = new OrderService();
            Product product = new Product(1,"apple", 10);
            List<OrderDetails> orderDetails = new List<OrderDetails> { new OrderDetails(1, product, 10) };
            orderService.AddOrder(1, "Alice", orderDetails);
            List<Order> o =orderService.QueryOrder(o=>o.OrderId==1);
            Order order = o[0];
            Assert.AreEqual(order.ToString(), "1 Alice 100");
        }
        [TestMethod]
        public void DeleteTest()
        {
            OrderService orderService = new OrderService();
            Product product = new Product(1, "apple", 10);
            List<OrderDetails> orderDetails = new List<OrderDetails> { new OrderDetails(1, product, 10) };
            orderService.AddOrder(1, "Alice", orderDetails);
            orderService.RemoveOrder(1);
            List<Order> o = orderService.QueryOrder(o => o.OrderId == 1);
            Assert.AreEqual(o.Count, 0);
        }
        [TestMethod]
        public void ModifyTest()
        {
            OrderService orderService = new OrderService();
            Product product = new Product(1, "apple", 10);
            List<OrderDetails> orderDetails = new List<OrderDetails> { new OrderDetails(1, product, 10) };
            orderService.AddOrder(1, "Alice", orderDetails);
            orderService.UpdateOrder(1, "Bob", orderDetails);
            List<Order> o = orderService.QueryOrder(o => o.OrderId == 1);
            Order order = o[0];
            Assert.AreEqual(order.ToString(), "1 Bob 100");
        }
        [TestMethod]
        public void QueryTest()
        {
            OrderService orderService = new OrderService();
            Product product = new Product(1, "apple", 10);
            List<OrderDetails> orderDetails = new List<OrderDetails> { new OrderDetails(1, product, 10) };
            orderService.AddOrder(1, "Alice", orderDetails);
            List<Order> o = orderService.QueryOrder(o => o.OrderId == 1);
            Order order = o[0];
            string s = order.ToString();
            Assert.AreEqual(s, "1 Alice 100");
        }
        [TestMethod]
        public void SortTest()
        {
            OrderService orderService = new OrderService();
            Product product = new Product(1, "apple", 10);
            List<OrderDetails> orderDetails = new List<OrderDetails> { new OrderDetails(1, product, 10) };
            orderService.AddOrder(2, "Alice", orderDetails);
            orderService.AddOrder(1, "Bob", orderDetails);
            orderService.SortOrders();
            List<Order> o = orderService.QueryOrder(o => true);
            Order order = o[0];
            Assert.AreEqual(order.ToString(), "1 Bob 100");
        }
    }
}