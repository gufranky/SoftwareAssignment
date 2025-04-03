using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5;
namespace Market
{
    public partial class Form2 : Form
    {
        public Form2(OrderService os,List<Product>products)
        {
            this.orderService = os;
            this.products = products;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add form2 = new Add(this.orderService, this.products, 1, Convert.ToInt32(textBox1.Text));
            form2.Show();
        }
    }
}
