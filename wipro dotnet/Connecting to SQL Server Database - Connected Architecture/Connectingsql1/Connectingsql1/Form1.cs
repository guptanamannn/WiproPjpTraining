using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connectingsql1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            { 
                con = new SqlConnection(@"Data Source = LAPTOP-0II0H94E\SPATA; Initial Catalog = Northwind; Integrated Security = True"); 
                SqlCommand cm = new SqlCommand("select FirstName from Employees", con);
                con.Open();  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    listBox1.Items.Add(sdr["FirstName"]);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("OOPs, something went wrong." + a);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
