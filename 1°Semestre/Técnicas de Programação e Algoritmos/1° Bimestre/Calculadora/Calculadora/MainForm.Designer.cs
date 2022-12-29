/*
 * Created by SharpDevelop.
 * User: luizi
 * Date: 26/12/2022
 * Time: 18:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculadora
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
			this.Dividir = new System.Windows.Forms.Button();
			this.Soma = new System.Windows.Forms.Button();
			this.Subtração = new System.Windows.Forms.Button();
			this.Apagar = new System.Windows.Forms.Button();
			this.Multiplicar = new System.Windows.Forms.Button();
			this.Raiz = new System.Windows.Forms.Button();
			this.Potência = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Coral;
			this.textBox1.Location = new System.Drawing.Point(54, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Nº 1";
			// 
			// Dividir
			// 
			this.Dividir.BackColor = System.Drawing.Color.Coral;
			this.Dividir.Location = new System.Drawing.Point(13, 12);
			this.Dividir.Name = "Dividir";
			this.Dividir.Size = new System.Drawing.Size(37, 23);
			this.Dividir.TabIndex = 1;
			this.Dividir.Text = "/";
			this.Dividir.UseVisualStyleBackColor = false;
			this.Dividir.Click += new System.EventHandler(this.DividirClick);
			// 
			// Soma
			// 
			this.Soma.BackColor = System.Drawing.Color.Coral;
			this.Soma.Location = new System.Drawing.Point(13, 42);
			this.Soma.Name = "Soma";
			this.Soma.Size = new System.Drawing.Size(37, 23);
			this.Soma.TabIndex = 2;
			this.Soma.Text = "+";
			this.Soma.UseVisualStyleBackColor = false;
			this.Soma.Click += new System.EventHandler(this.SomaClick);
			// 
			// Subtração
			// 
			this.Subtração.BackColor = System.Drawing.Color.Coral;
			this.Subtração.Location = new System.Drawing.Point(13, 70);
			this.Subtração.Name = "Subtração";
			this.Subtração.Size = new System.Drawing.Size(37, 23);
			this.Subtração.TabIndex = 3;
			this.Subtração.Text = "-";
			this.Subtração.UseVisualStyleBackColor = false;
			this.Subtração.Click += new System.EventHandler(this.SubtraçãoClick);
			// 
			// Apagar
			// 
			this.Apagar.BackColor = System.Drawing.Color.Coral;
			this.Apagar.Location = new System.Drawing.Point(13, 99);
			this.Apagar.Name = "Apagar";
			this.Apagar.Size = new System.Drawing.Size(37, 23);
			this.Apagar.TabIndex = 4;
			this.Apagar.Text = "C";
			this.Apagar.UseVisualStyleBackColor = false;
			this.Apagar.Click += new System.EventHandler(this.ApagarClick);
			// 
			// Multiplicar
			// 
			this.Multiplicar.BackColor = System.Drawing.Color.Coral;
			this.Multiplicar.Location = new System.Drawing.Point(54, 99);
			this.Multiplicar.Name = "Multiplicar";
			this.Multiplicar.Size = new System.Drawing.Size(37, 23);
			this.Multiplicar.TabIndex = 5;
			this.Multiplicar.Text = "X";
			this.Multiplicar.UseVisualStyleBackColor = false;
			this.Multiplicar.Click += new System.EventHandler(this.MultiplicarClick);
			// 
			// Raiz
			// 
			this.Raiz.BackColor = System.Drawing.Color.Coral;
			this.Raiz.Location = new System.Drawing.Point(97, 99);
			this.Raiz.Name = "Raiz";
			this.Raiz.Size = new System.Drawing.Size(37, 23);
			this.Raiz.TabIndex = 6;
			this.Raiz.Text = "√";
			this.Raiz.UseVisualStyleBackColor = false;
			this.Raiz.Click += new System.EventHandler(this.RaizClick);
			// 
			// Potência
			// 
			this.Potência.BackColor = System.Drawing.Color.Coral;
			this.Potência.Location = new System.Drawing.Point(140, 99);
			this.Potência.Name = "Potência";
			this.Potência.Size = new System.Drawing.Size(37, 23);
			this.Potência.TabIndex = 7;
			this.Potência.Text = "^";
			this.Potência.UseVisualStyleBackColor = false;
			this.Potência.Click += new System.EventHandler(this.PotênciaClick);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Coral;
			this.textBox2.Location = new System.Drawing.Point(54, 44);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(123, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.Text = "Nº2";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.Coral;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(54, 73);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(123, 20);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "Resultado";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(189, 133);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Potência);
			this.Controls.Add(this.Raiz);
			this.Controls.Add(this.Multiplicar);
			this.Controls.Add(this.Apagar);
			this.Controls.Add(this.Subtração);
			this.Controls.Add(this.Soma);
			this.Controls.Add(this.Dividir);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button Potência;
		private System.Windows.Forms.Button Raiz;
		private System.Windows.Forms.Button Multiplicar;
		private System.Windows.Forms.Button Apagar;
		private System.Windows.Forms.Button Subtração;
		private System.Windows.Forms.Button Soma;
		private System.Windows.Forms.Button Dividir;
		private System.Windows.Forms.TextBox textBox1;
	}
}
