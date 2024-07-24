using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Welcome";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double ans = num1 + num2;
            textBox3.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(textBox4.Text);
            double no2 = double.Parse(textBox5.Text);
            double tot = no1 + no2;
            label7.Text = tot.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(textBox4.Text);
            double no2 = double.Parse(textBox5.Text);
            double tot = no1 - no2;
            label7.Text = tot.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(textBox4.Text);
            double no2 = double.Parse(textBox5.Text);
            double tot = no1 * no2;
            label7.Text = tot.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(textBox4.Text);
            double no2 = double.Parse(textBox5.Text);
            double tot = no1 / no2;
            label7.Text = tot.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            label7.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "F' to C'")
            {
                //code
                double f = double.Parse(textBox7.Text);
                double c = (f - 32) * 5 / 9;

                label11.Text = c.ToString();

            }
            else if (comboBox1.Text == "C' to F'")
            {
                //code
                double c = double.Parse(textBox7.Text);
                double f = (c * 9 / 5) + 32;

                label11.Text = f.ToString();
            }
            else
            {
                //code
                label11.Text = "Please seelect one from the above list";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                double f = double.Parse(textBox6.Text);
                double c = (f - 32) * 5 / 9;

                label12.Text = c.ToString();
            }
            else if(radioButton2.Checked == true)
            {
                double c = double.Parse(textBox6.Text);
                double f = (c * 9 / 5) + 32;

                label12.Text = f.ToString();
            }
        }
    }
}
