using Assignment5;
namespace Market
{
    public partial class Form1 : Form
    {
        public Form1(OrderService orderService)
        {
            InitializeComponent();
            orderServiceBindingSource.DataSource = orderService;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add form2 = new Add();
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
            dataGridView1.DataSource = orderServiceBindingSource;
        }
    }
}