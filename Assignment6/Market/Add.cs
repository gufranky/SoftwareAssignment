using Assignment5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Add : Form
    {
        public Add(OrderService os, List<Product> products, int mode, int orderid)
        {
            InitializeComponent();
            this.products = products;
            this.orderService = os;
            this.mode = mode;
            if (mode == 0)
            {
                List<OrderDetails> list = new List<OrderDetails>();
                nowid = os.orders.Max(o => o.OrderId) + 1;
                orderDetailsBindingSource.DataSource = list;
                dataGridView1.DataSource = orderDetailsBindingSource;
            }
            else
            {
                List<OrderDetails> list = orderService.orders[orderid].OrderDetails;
                nowid = orderid;
                orderDetailsBindingSource.DataSource = list;
                dataGridView1.DataSource = orderDetailsBindingSource;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox2.Text;
            int price = Convert.ToInt32(textBox3.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            bool find = false;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == productName)
                {
                    OrderDetails orderDetails = new OrderDetails(nowid, products[i], quantity);
                    orderDetailsBindingSource.Add(orderDetails);
                    find = true;
                    break;
                }
            }
            if (!find)
            {
                products.Add(new Product(products.Max(o => o.Productid) + 1, productName, price));
                OrderDetails orderDetails = new OrderDetails(nowid, products[products.Max(o => o.Productid)], quantity);
                orderDetailsBindingSource.Add(orderDetails);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                bool status = orderService.AddOrder(nowid, textBox1.Text, orderDetailsBindingSource.List.Cast<OrderDetails>().ToList());
                if (status)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                bool status = orderService.UpdateOrder(nowid, textBox1.Text, orderDetailsBindingSource.List.Cast<OrderDetails>().ToList());
                if (status)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }
    }
}
