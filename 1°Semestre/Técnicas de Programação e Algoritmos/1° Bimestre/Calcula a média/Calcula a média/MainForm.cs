/*
 * Created by SharpDevelop.
 * User: luizi
 * Date: 17/12/2022
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calcula_a_média
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CalcularBTNClick(object sender, EventArgs e)
		{
			double a, b, c, d, g, f; 
			a = double.Parse(textBox1.Text); 
			b = double.Parse(textBox2.Text); 
			c = double.Parse(textBox3.Text); 
			d = double.Parse(textBox4.Text); 
			g = double.Parse(textBox5.Text); 
			f = (a+b+c+d+g)/5; 
			textBox6.Text = f.ToString();
		}
		
		void LimparBTNClick(object sender, EventArgs e)
		{
			textBox1.Clear(); 
			textBox2.Clear(); 
			textBox3.Clear(); 
			textBox4.Clear(); 
			textBox5.Clear();
			textBox6.Clear();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			panel1.Visible = false;
		}
	}
}
