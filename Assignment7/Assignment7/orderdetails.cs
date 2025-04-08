using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class OrderDetails
    {
        public int DetailsId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Product product1 { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice => Quantity * product1.Price;
        public OrderDetails(int orderId, Product product1, int quantity)
        {
            OrderId = orderId;
            this.product1 = product1;
            Quantity = quantity;
        }
        public override bool Equals(object obj)
        {
            if (obj is OrderDetails orderDetails)
            {
                return OrderId == orderDetails.OrderId && product1 == orderDetails.product1;
            }
            return false;
        }
        public override string ToString()
        {
            return (OrderId + " " + product1 + " " + Quantity + " " + product1.Price);
        }

    }
}
