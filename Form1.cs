using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_YT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "+";
        }
        int number1;
        int number2;
        int result;
        string str;

        private void button5_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(textBox1.Text);

            switch (str)
            {
                case "+":result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            textBox1.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            number1 = 0;
            number2 = 0;
            result = 0;
            str = "";


        }
    }
}
