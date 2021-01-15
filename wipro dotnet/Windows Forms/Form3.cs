using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void btngenerate_Click(object sender, EventArgs e)
        {
           
                int a = 0;
                int b = 15;
                Random random = new Random();
            txtnum1.Text = random.Next(a, b).ToString();
            txtnum2.Text = random.Next(a, b).ToString();
            txtnum3.Text = random.Next(a, b).ToString();
            int first = int.Parse(txtnum1.Text);
            int second = int.Parse(txtnum2.Text);
            int third = int.Parse(txtnum3.Text);
            int sum = first + second + third;
            
            if (sum > 21)
            {
               
                pictureBox1.ImageLocation = "D:\\desktop\\images\\youwin.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                MessageBox.Show("You have won the Game");

            }
            else
            {
                
                pictureBox1.ImageLocation = "D:\\desktop\\images\\lose.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                MessageBox.Show("OOPs better luck next Time");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        
           
        

       
    }
}
