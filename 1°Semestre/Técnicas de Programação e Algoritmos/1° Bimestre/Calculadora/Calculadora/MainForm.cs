using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void DividirClick(object sender, EventArgs e)
		{
			double s, t, v; 	
			s = double.Parse(textBox1.Text); 
			t = double.Parse(textBox2.Text); 
			v = s/t; 
			textBox3.Text = v.ToString();
		}
		
		void SomaClick(object sender, EventArgs e)
		{
			int s, t, v; 
			s = int.Parse(textBox1.Text); 
			t = int.Parse(textBox2.Text); 
			v = s+t; 
			textBox3.Text = v.ToString();
		}
		
		void SubtraçãoClick(object sender, EventArgs e)
		{
			int s, t, v; 
			s = int.Parse(textBox1.Text); 
			t = int.Parse(textBox2.Text); 
			v = s-t; 
			textBox3.Text = v.ToString();
		}
		
		void MultiplicarClick(object sender, EventArgs e)
		{
			int s, t, v;
			s = int.Parse(textBox1.Text);
			t = int.Parse(textBox2.Text); 
			v = s*t; 
			textBox3.Text = v.ToString();
		}
		
		void RaizClick(object sender, EventArgs e)
		{
			double t, v; 
			t=double.Parse(textBox1.Text); 
			v=Math.Sqrt(t); 
			textBox3.Text= v.ToString();
		}
		
		void PotênciaClick(object sender, EventArgs e)
		{
			//double t, v; 
			//t=double.Parse(textBox1.Text); 
			//v=Math.Pow(t); 
			//textBox3.Text= v.ToString();
		}
		
		void ApagarClick(object sender, EventArgs e)
		{
			textBox1.Clear(); 
			textBox2.Clear(); 
			textBox3.Clear();
		}
	}
}
