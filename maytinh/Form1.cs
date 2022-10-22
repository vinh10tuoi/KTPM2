using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != String.Empty || textBox2.Text != String.Empty)
            //{
            //    double a = int.Parse(textBox1.Text);
            //    double b = int.Parse(textBox2.Text);

            //    textBox3.Text = (a + b).ToString();
            //}

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            
            calculation c = new calculation(a, b);
            textBox3.Text = c.ex("+").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //double a = int.Parse(textBox1.Text);
            //double b = int.Parse(textBox2.Text);

            //textBox3.Text = (a - b).ToString();

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            calculation c = new calculation(a, b);
            textBox3.Text = c.ex("-").ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            calculation c = new calculation(a, b);
            textBox3.Text = c.ex("*").ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            calculation c = new calculation(a, b);
            textBox3.Text = c.ex("/").ToString();
        }
    }
}
