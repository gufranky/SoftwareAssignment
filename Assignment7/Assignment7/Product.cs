using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Product
    {
        public int Productid { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int productid, string name, double price)
        {
            Productid = productid;
            Name = name;
            Price = price;
        }
        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return Productid == product.Productid;
            }
            return false;
        }
        public override string ToString()
        {
            return (Name + " " + Price);
        }
    }
