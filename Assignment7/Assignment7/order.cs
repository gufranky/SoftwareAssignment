using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public double TotalPrice => OrderDetails.Sum(d => d.TotalPrice);
        public string list => OrderDetails.ToString();
        public override bool Equals(object obj)
        {
            if (obj is Order order)
            {
                return OrderId == order.OrderId;
            }
            return false;
        }
        public override string ToString()
        {
            string output = OrderId + " " + Customer + " " + TotalPrice;
            return output;
        }

    }
}
