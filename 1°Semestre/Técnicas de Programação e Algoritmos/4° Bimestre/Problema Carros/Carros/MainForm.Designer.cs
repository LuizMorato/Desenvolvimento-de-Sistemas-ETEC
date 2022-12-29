/*
 * Created by SharpDevelop.
 * User: RM20222930098
 * Date: 02/12/2022
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Carros
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtbInput;
		private System.Windows.Forms.RichTextBox rtbOutput;
		private System.Windows.Forms.Button Leitura;
		private System.Windows.Forms.Button Processamento;
		private System.Windows.Forms.Button Salvar;
		private System.Windows.Forms.Label media1;
		private System.Windows.Forms.Panel panel1;
		
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
			this.rtbInput = new System.Windows.Forms.RichTextBox();
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.Leitura = new System.Windows.Forms.Button();
			this.Processamento = new System.Windows.Forms.Button();
			this.Salvar = new System.Windows.Forms.Button();
			this.media1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// rtbInput
			// 
			this.rtbInput.Location = new System.Drawing.Point(12, 12);
			this.rtbInput.Name = "rtbInput";
			this.rtbInput.Size = new System.Drawing.Size(161, 273);
			this.rtbInput.TabIndex = 0;
			this.rtbInput.Text = "";
			// 
			// rtbOutput
			// 
			this.rtbOutput.Location = new System.Drawing.Point(376, 12);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.Size = new System.Drawing.Size(161, 273);
			this.rtbOutput.TabIndex = 1;
			this.rtbOutput.Text = "";
			// 
			// Leitura
			// 
			this.Leitura.Location = new System.Drawing.Point(232, 24);
			this.Leitura.Name = "Leitura";
			this.Leitura.Size = new System.Drawing.Size(90, 23);
			this.Leitura.TabIndex = 2;
			this.Leitura.Text = "Ler o arquivo";
			this.Leitura.UseVisualStyleBackColor = true;
			this.Leitura.Click += new System.EventHandler(this.LeituraClick);
			// 
			// Processamento
			// 
			this.Processamento.Location = new System.Drawing.Point(232, 53);
			this.Processamento.Name = "Processamento";
			this.Processamento.Size = new System.Drawing.Size(90, 23);
			this.Processamento.TabIndex = 3;
			this.Processamento.Text = "Processar";
			this.Processamento.UseVisualStyleBackColor = true;
			this.Processamento.Click += new System.EventHandler(this.ProcessamentoClick);
			// 
			// Salvar
			// 
			this.Salvar.Location = new System.Drawing.Point(232, 82);
			this.Salvar.Name = "Salvar";
			this.Salvar.Size = new System.Drawing.Size(90, 23);
			this.Salvar.TabIndex = 4;
			this.Salvar.Text = "Salvar";
			this.Salvar.UseVisualStyleBackColor = true;
			this.Salvar.Click += new System.EventHandler(this.SalvarClick);
			// 
			// media1
			// 
			this.media1.BackColor = System.Drawing.Color.Lavender;
			this.media1.Location = new System.Drawing.Point(216, 157);
			this.media1.Name = "media1";
			this.media1.Size = new System.Drawing.Size(122, 58);
			this.media1.TabIndex = 5;
			this.media1.Text = "Média em km:";
			this.media1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Lime;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(179, 53);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(191, 88);
			this.panel1.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AcceptButton = this.Leitura;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Lime;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(550, 297);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.media1);
			this.Controls.Add(this.Salvar);
			this.Controls.Add(this.Processamento);
			this.Controls.Add(this.Leitura);
			this.Controls.Add(this.rtbOutput);
			this.Controls.Add(this.rtbInput);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Carros";
			this.ResumeLayout(false);
		}
	}
}
