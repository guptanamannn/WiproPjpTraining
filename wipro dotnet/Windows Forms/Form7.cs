using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
           


        }

        private void listdepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string name = textBox2.Text;
            string joindate = textBox3.Text;
            
            
                DateTime join = Convert.ToDateTime(joindate,
    System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);

            string depart = textBox4.Text;
                string salary = textBox5.Text;
                DateTime today = DateTime.Today;
                if (encumber.Items.Contains(number))
                {
                    MessageBox.Show("enter a unique encumber");
                }
                if (name.Length == 0)
                {
                    MessageBox.Show("name cannot be empty");
                }
                if (join.Date >= today.Date && join.Month >= today.Month && join.Year >= today.Year)
                {
                    MessageBox.Show("Date of Joining should be less than todays date");
                }
                if (listdepartment.Items.Contains(depart))
                { }
                else
                {
                    MessageBox.Show("department entered should be the only already present in the given list");
                }
                encumber.Items.Add(number);
                if (Convert.ToInt32(salary) < 100000 || Convert.ToInt32(salary) > 50000000)
                {
                    MessageBox.Show("Salary should be  between 100000 and 50000000");
                }
               
            }
    }
}
