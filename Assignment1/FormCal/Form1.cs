using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            if (listBox1.Text == "+")
            {
                label3.Text =Convert.ToString( a + b);
            }
            else if(listBox1.Text == "-")
            {
                label3.Text = Convert.ToString(a - b);
            }
            else if (listBox1.Text == "*")
            {
                label3.Text = Convert.ToString(a * b);
            }
            else if (listBox1.Text == "/")
            {
                label3.Text = Convert.ToString(a / b);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "FormCalculator";
        }
    }
}
