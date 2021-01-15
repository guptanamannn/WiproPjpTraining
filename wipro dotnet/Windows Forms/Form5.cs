using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsForms5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

             DriveInfo[] alldrives = DriveInfo.GetDrives();

              foreach (DriveInfo di in alldrives)
              {
                  comboBox1.Items.Add(di.Name);
              }
            

           
            

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string a = comboBox1.Text;
            DirectoryInfo obj = new DirectoryInfo(a);
            
            DirectoryInfo[] folders = obj.GetDirectories();
            foreach (DirectoryInfo file in folders)
            {
                listBox1.Items.Add(file.ToString());
            }
        }
    }
}
