using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtNumber_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void btnsubmit_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(txtNumber.Text);
			if (n%2 == 0)
			{
				MessageBox.Show(n+" is a even number");
			}
			else
			{
				MessageBox.Show(n+" is a odd number");
			}
		}
	}
}
