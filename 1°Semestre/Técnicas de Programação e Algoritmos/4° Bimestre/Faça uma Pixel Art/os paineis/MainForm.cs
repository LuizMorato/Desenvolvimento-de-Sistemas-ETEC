//Faça algum desenho nesses 100 painéis, você pode salvar o desenho num arquivo .txt, 
//estará salvo na pasta bin/Debug
//deste diretório, poderá abrir novamente o mesmo desenho (só pode salvar apenas um)
//Pixel Art ;)


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace os_paineis
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Colorir(object sender, EventArgs e)
		{
			//para colorir
			PictureBox btn = (sender as PictureBox);
			panel1.BackColor = btn.BackColor;
		}
		
		void Coloridos(object sender, EventArgs e)
		{
			//painel que vai ser colorido
			Panel bt = (sender as Panel);
			bt.BackColor = panel1.BackColor;
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			//botão sair
			this.Close();
		}
		
		void SalvarComoToolStripMenuItemClick(object sender, EventArgs e)
		{
			//botão salvar como
			SaveFileDialog doc = new SaveFileDialog();
			doc.Filter = "Arquivo de Texto | *.txt";
			doc.ShowDialog();
		}
			
//			if(string.IsNullOrEmpty(doc.FileName) == false)
//			{
//				try
//				{
//					using(StreamWriter writer = new StreamWriter(doc.FileName, false, Encoding.UTF8))
//					{
//						writer.Write(panel3);
//						writer.Flush();
//					}
//				}
//				catch (Exception ex)
//				{
//					MessageBox.Show(string.Format("Não foi possível salvar o seu arquivo. Erro: {0}", ex.Message), "Atenção", MessageBoxButtona.OK, MessageBoxIcon.Error);
//				}						
//			}
//		}
		
		void AbrirToolStripMenuItemClick(object sender, EventArgs e)
		{
			//botão abrir
			OpenFileDialog abrir = new OpenFileDialog();
			abrir.Filter = "Arquivo texto | *.txt";
			abrir.ShowDialog();
		}
	}
}
