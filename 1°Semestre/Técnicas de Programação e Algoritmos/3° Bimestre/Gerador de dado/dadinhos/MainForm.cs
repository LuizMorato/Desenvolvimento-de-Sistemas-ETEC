using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dadinhos
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		Random rnd = new Random();
		
		void Button1Click(object sender, EventArgs e)
		{
			int n = rnd.Next(1,7);
			label1.Text = n.ToString();
			pictureBox1.Load("dado"+n+".png");
		}
	}
}
