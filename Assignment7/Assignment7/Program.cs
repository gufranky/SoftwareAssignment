using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Product[] products = new Product[5] { new Product(1, "apple", 5), new Product(2, "banana", 3), new Product(3, "orange", 4), new Product(4, "pear", 2), new Product(5, "grape", 6) };
            List<OrderDetails> orderDetails1 = new List<OrderDetails> { new OrderDetails(1, products[0], 10) };
            List<OrderDetails> orderDetails2 = new List<OrderDetails> { new OrderDetails(2, products[2], 10), new OrderDetails(2, products[3], 1) };
            orderService.AddOrder(1, "Alice", orderDetails1);
            orderService.AddOrder(2, "Bob", orderDetails2);
            Console.WriteLine("请选择需要的功能：");
            Console.WriteLine("1.添加订单");
            Console.WriteLine("2.删除订单");
            Console.WriteLine("3.修改订单");
            Console.WriteLine("4.查询订单");
            Console.WriteLine("5.排序订单");
            Console.WriteLine("6.退出");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 6)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("请输入订单号：");
                        int orderId = int.Parse(Console.ReadLine());
                        Console.WriteLine("请输入顾客名：");
                        string customer = Console.ReadLine();
                        Console.WriteLine("请输入订单明细：");
                        List<OrderDetails> orderDetails = new List<OrderDetails>();
                        Console.WriteLine("请输入商品数量：");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("请输入商品价格：");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("请输入商品编号：");
                        int productId = int.Parse(Console.ReadLine());
                        Product product = new Product(productId, "product", price);
                        OrderDetails orderDetail = new OrderDetails(orderId, product, quantity);
                        orderDetails.Add(orderDetail);
                        orderService.AddOrder(orderId, customer, orderDetails);
                        break;
                    case 2:
                        Console.WriteLine("请输入订单号：");
                        int orderId1 = int.Parse(Console.ReadLine());
                        if (orderService.RemoveOrder(orderId1))
                        {
                            Console.WriteLine("删除成功");
                        }
                        else
                        {
                            Console.WriteLine("删除失败");
                        }
                        break;
                    case 3:
                        Console.WriteLine("请输入订单号：");
                        int orderId2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("请输入顾客名：");
                        string customer1 = Console.ReadLine();
                        Console.WriteLine("请输入订单明细：");
                        List<OrderDetails> orderDetails3 = new List<OrderDetails>();
                        Console.WriteLine("请输入商品数量：");
                        int quantity1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("请输入商品价格：");
                        double price1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("请输入商品编号：");
                        int productId1 = int.Parse(Console.ReadLine());
                        Product product1 = new Product(productId1, "product", price1);
                        OrderDetails orderDetail1 = new OrderDetails(orderId2, product1, quantity1);
                        orderDetails3.Add(orderDetail1);
                        if (orderService.UpdateOrder(orderId2, customer1, orderDetails3))
                        {
                            Console.WriteLine("修改成功");
                        }
                        else
                        {
                            Console.WriteLine("修改失败");
                        }

                        break;
                    case 4:
                        Console.WriteLine("请输入查询条件：");
                        Console.WriteLine("1.按订单号查询");
                        Console.WriteLine("2.按顾客名查询");
                        string condition = Console.ReadLine();
                        if (condition == "1")
                        {
                            Console.WriteLine("请输入订单号：");
                            int orderId3 = int.Parse(Console.ReadLine());
                            var target = orderService.QueryOrder(o => o.OrderId == orderId3);
                            foreach (var o in target)
                            {
                                Console.WriteLine(o);
                            }
                        }
                        else
                        {
                            Console.WriteLine("请输入顾客名：");
                            string customer2 = Console.ReadLine();
                            var target = orderService.QueryOrder(o => o.Customer == customer2);
                            foreach (var o in target)
                            {
                                Console.WriteLine(o);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("请选择排序方式：");
                        Console.WriteLine("1.按订单号排序");
                        Console.WriteLine("2.按总价排序");
                        int choice1 = int.Parse(Console.ReadLine());
                        if (choice1 == 1)
                        {
                            orderService.SortOrders(o => o.OrderId);
                        }
                        else
                        {
                            orderService.SortOrders(o => o.TotalPrice);
                        }
                        foreach (var o in orderService.QueryOrder(o => true))
                        {
                            Console.WriteLine(o);
                        }
                        break;
                    case 6:
                        break;

                }
            }
            choice = int.Parse(Console.ReadLine());
        }
    }
}
