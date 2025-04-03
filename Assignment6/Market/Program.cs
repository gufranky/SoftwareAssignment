using Assignment5;
using System.Collections.Generic;
namespace Market

{
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OrderService orderService = new OrderService();
            List<Product> products = new List<Product> { new Product(1, "apple", 5), new Product(2, "banana", 3), new Product(3, "orange", 4), new Product(4, "pear", 2), new Product(5, "grape", 6) };  
            List<OrderDetails> orderDetails1 = new List<OrderDetails> { new OrderDetails(1, products[0], 10) };
            List<OrderDetails> orderDetails2 = new List<OrderDetails> { new OrderDetails(2, products[2], 10),new OrderDetails(2, products[3],1) };
            orderService.AddOrder(1, "Alice", orderDetails1);
            orderService.AddOrder(2, "Bob", orderDetails2);
            orderService.AddOrder(3, "Cat", orderDetails2);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(orderService,products));
        }
    }
}