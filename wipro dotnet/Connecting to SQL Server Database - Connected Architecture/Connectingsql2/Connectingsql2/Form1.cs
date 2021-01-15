using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connectingsql2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection(@"Data Source=LAPTOP-0II0H94E\SPATA;Initial Catalog=Empmanagement;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into Employee values(7,'Abhishek','analyst','B.Tech','08-11-2018')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record entered successfully");
            }
            catch(Exception a)
            {
                MessageBox.Show("Oops something went wrong" + a);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection(@"Data Source=LAPTOP-0II0H94E\SPATA;Initial Catalog=Empmanagement;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update Employee set Empname='sharanya' where Empid=2", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully");
            }
            catch (Exception a)
            {
                MessageBox.Show("Oops something went wrong" + a);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection(@"Data Source=LAPTOP-0II0H94E\SPATA;Initial Catalog=Empmanagement;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from Employee where Empid=6", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");
            }
            catch (Exception a)
            {
                MessageBox.Show("Oops something went wrong" + a);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int  id = int.Parse(textBox1.Text);
            SqlConnection con;
            try
            { 
                con = new SqlConnection(@"Data Source=LAPTOP-0II0H94E\SPATA;Initial Catalog=Empmanagement;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from Employee where Empid=1", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = rdr;
                dataGridView1.DataSource = source;
                con.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Oops something went wrong" + a);
            }
        }
    }
}
