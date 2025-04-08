using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public OrderService()
        {
            using (var db=new OrderDb())
            {
                orders = db.Orders.ToList();
            }
        }
        public bool AddOrder(int orderId, string customer, List<OrderDetails> orderDetails)
        {
            using (var db =new OrderDb())
            {
                var target = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (target != null)
                {
                    return false;
                }
                var order = new Order
                {
                    OrderId = orderId,
                    Customer = customer,
                    OrderDetails = orderDetails
                };
                db.Orders.Add(order);
                db.SaveChanges();
                return true;
            }
        }
        public bool RemoveOrder(int orderId)
        {
            using (var db = new OrderDb())
            {
                var target=db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (target == null)
                {
                    return false;
                }
                db.Orders.Remove(target);
                db.SaveChanges();
                return true;
            }
        }
        public bool UpdateOrder(int orderId, string customer, List<OrderDetails> orderDetails)
        {
            using (var db = new OrderDb())
            {
                var target = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (target == null)
                {
                    return false;
                }
                target.Customer = customer;
                target.OrderDetails = orderDetails;
                db.SaveChanges();
                return true;
            }
        }
        public List<Order> QueryOrder(Func<Order, bool> predicate)
        {
            using (var db = new OrderDb())
            {
                return db.Orders.Where(predicate).ToList();
            }
        }
        public void SortOrders(Func<Order, object> keySelector = null)
        {
            if (keySelector == null)
            {
                orders = orders.OrderBy(o => o.OrderId).ToList();
            }
            else
            {
                orders = orders.OrderBy(keySelector).ToList();
            }
        }
    }
}
