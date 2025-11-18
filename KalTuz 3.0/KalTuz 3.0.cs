using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;

namespace Kaltuz
{
    public partial class KalTuz : Form
    {
        public double number;
        public string operation;

        public KalTuz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            operation = button11.Text;
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            operation = button12.Text;
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            operation = button13.Text;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            operation = button14.Text;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            operation = button16.Text;
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(number * number);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(number * number * number);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double equals = Convert.ToDouble(textBox1.Text);
            if (operation == button11.Text)
            {
                textBox1.Text = Convert.ToString(number + equals);
                number = Convert.ToDouble(textBox1.Text);
            }
            else if (operation == button12.Text)
            {
                textBox1.Text = Convert.ToString(number - equals);
                number = Convert.ToDouble(textBox1.Text);
            }
            else if (operation == button13.Text)
            {
                textBox1.Text = Convert.ToString(number * equals);
                number = Convert.ToDouble(textBox1.Text);
            }
            else if (operation == button14.Text)
            {
                if(equals == 0)
                {
                    textBox1.Text = "Делить на ноль нельзя!";
                }
                else
                {
                    textBox1.Text = Convert.ToString(number / equals);
                    number = Convert.ToDouble(textBox1.Text);
                }
            }
            else if (operation == button16.Text)
            {
                textBox1.Text = Convert.ToString(number / 100 * equals);
                number = Convert.ToDouble(textBox1.Text);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
