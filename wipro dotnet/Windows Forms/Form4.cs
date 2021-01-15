using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text+btn1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btndot.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
        double total1 = 0;
        double total2 = 0;
        bool plusbtn = false;
        bool minusbtn = false;
        bool intobtn = false;
        bool divbtn = false;
        private void button13_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusbtn = true;
            minusbtn =false;
            intobtn = false;
            divbtn = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            total1 = total1 +double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusbtn = false;
            minusbtn = false;
            intobtn = true;
            divbtn = false;
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusbtn = false;
            minusbtn = true;
            intobtn = false;
            divbtn = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusbtn = false;
            minusbtn = false;
            intobtn = false;
            divbtn = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {   if (plusbtn == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
           else if (minusbtn == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (intobtn == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (divbtn == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        
    }
}
