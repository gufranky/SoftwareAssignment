using System;
using System.Data.Entity;
using System.Linq;

namespace Assignment7
{
    public class OrderDb : DbContext
    {

        public OrderDb()
            : base("OrderDbbase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderDb>());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }

}