using Assignment5;
using System.Security.Cryptography.X509Certificates;

namespace Market
{
    public partial class Form1 : Form
    {
        public Form1(OrderService orderService, List<Product> products)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.products = products;
            orderBindingSource.DataSource = orderService.orders;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add form2 = new Add(this.orderService, this.products, 0, 0);
            form2.Show();
            //��form2
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderServiceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orderBindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Order> resultorder = orderService.QueryOrder(o => o.Customer == textBox1.Text);
            orderBindingSource.DataSource = resultorder;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool status = this.orderService.RemoveOrder(Convert.ToInt32(textBox2.Text));
            if (status)
            {
                MessageBox.Show("删除成功");
                orderBindingSource.DataSource = orderService.orders;
                dataGridView1.Invalidate();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.orderService, this.products);
            form2.Show();

        }
    }
}