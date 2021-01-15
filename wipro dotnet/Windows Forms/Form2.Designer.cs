namespace WindowsForms2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnsubmit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(376, 162);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(100, 20);
			this.txtNumber.TabIndex = 0;
			this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(272, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "enter the number";
			// 
			// btnsubmit
			// 
			this.btnsubmit.Location = new System.Drawing.Point(400, 232);
			this.btnsubmit.Name = "btnsubmit";
			this.btnsubmit.Size = new System.Drawing.Size(75, 23);
			this.btnsubmit.TabIndex = 2;
			this.btnsubmit.Text = "submit";
			this.btnsubmit.UseVisualStyleBackColor = true;
			this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnsubmit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNumber);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsubmit;
	}
}

