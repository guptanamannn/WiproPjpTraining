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

namespace WindowsForms6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string a = textBox1.Text;
            DirectoryInfo obj;
            if (a.Equals("c") || a.Equals("d") || a.Equals("e"))
             {
                obj = new DirectoryInfo(a + ":\\");
            }
            else
            {
                obj = new DirectoryInfo(a);
            }
            DirectoryInfo[] folders = obj.GetDirectories();
            foreach(DirectoryInfo file in folders)
            {
                listBox1.Items.Add(file.ToString());
            }
        }
    }
}
