namespace ComputeWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                label1.Text = "请输入两个整数";
                return;
            }
            if(textBox1.Text.All(char.IsDigit)== false || textBox2.Text.All(char.IsDigit) == false)
            {
                label1.Text = "请输入整数";
                return;
            }
            int first = int.Parse(textBox1.Text);
            int second = int.Parse(textBox2.Text);
            if (checkBox1.Checked)
            {
                label1.Text = (first + second).ToString();
            }
            else if (checkBox2.Checked)
            {
                label1.Text = (first - second).ToString();
            }
            else if (checkBox3.Checked)
            {
                label1.Text = (first * second).ToString();
            }
            else if (checkBox4.Checked)
            {
                if (second == 0)
                {
                    label1.Text = "除数不能为0";
                }
                else
                {
                    label1.Text = (first / second).ToString();
                }
            }
        }
    }
}