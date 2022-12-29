/*
 * Created by SharpDevelop.
 * User: luizi
 * Date: 17/12/2022
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calcula_a_média
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.CalcularBTN = new System.Windows.Forms.Button();
			this.LimparBTN = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ComecarBTN = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(91, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Número 1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(91, 74);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Número 2";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(91, 100);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Número 3";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(91, 126);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "Número 4";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(91, 152);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "Número 5";
			// 
			// CalcularBTN
			// 
			this.CalcularBTN.BackColor = System.Drawing.Color.Lime;
			this.CalcularBTN.Location = new System.Drawing.Point(91, 178);
			this.CalcularBTN.Name = "CalcularBTN";
			this.CalcularBTN.Size = new System.Drawing.Size(100, 23);
			this.CalcularBTN.TabIndex = 5;
			this.CalcularBTN.Text = "CALCULAR";
			this.CalcularBTN.UseVisualStyleBackColor = false;
			this.CalcularBTN.Click += new System.EventHandler(this.CalcularBTNClick);
			// 
			// LimparBTN
			// 
			this.LimparBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.LimparBTN.Location = new System.Drawing.Point(91, 207);
			this.LimparBTN.Name = "LimparBTN";
			this.LimparBTN.Size = new System.Drawing.Size(100, 23);
			this.LimparBTN.TabIndex = 6;
			this.LimparBTN.Text = "LIMPAR";
			this.LimparBTN.UseVisualStyleBackColor = false;
			this.LimparBTN.Click += new System.EventHandler(this.LimparBTNClick);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(91, 237);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 7;
			this.textBox6.Text = "Resultado";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(109, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 36);
			this.label1.TabIndex = 8;
			this.label1.Text = "DIGITE 5 NÚMEROS";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ComecarBTN);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(187, 115);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(75, 144);
			this.panel1.TabIndex = 9;
			// 
			// ComecarBTN
			// 
			this.ComecarBTN.Location = new System.Drawing.Point(89, 114);
			this.ComecarBTN.Name = "ComecarBTN";
			this.ComecarBTN.Size = new System.Drawing.Size(75, 23);
			this.ComecarBTN.TabIndex = 1;
			this.ComecarBTN.Text = "Começar!";
			this.ComecarBTN.UseVisualStyleBackColor = true;
			this.ComecarBTN.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(78, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 34);
			this.label2.TabIndex = 0;
			this.label2.Text = "CALCULADORA DE MÉDIAS";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(276, 266);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.LimparBTN);
			this.Controls.Add(this.CalcularBTN);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Calcula a média";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button ComecarBTN;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button LimparBTN;
		private System.Windows.Forms.Button CalcularBTN;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}
