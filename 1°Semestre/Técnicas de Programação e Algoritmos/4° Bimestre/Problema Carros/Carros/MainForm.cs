//Uma empresa possui uma frota de veículos e precisa saber a lista dos carros mais econômicos. 
//Para tanto, uma equipe de pesquisadores contratada fez um experimento e 
//registrou o desempenho de cada carro, despejando os dados em um arquivo ("carros.txt"),
//contendo em cada linha a placa e a quantidade de quilômetros rodados com um tanque cheio.
//Faça um programa que leia esse arquivo, calcule e exiba na tela a média de km dentre todos 
//os carros da frota, depois gere um arquivo "economicos.txt" com as placas dos carros 
//que possuam desempenho acima da média.
//
//carros.txt:
//CDD5055;350
//ABF2312;158
//POY8794;200
//AWD9106;134
//QRR3620;401
//CFF4877;207
//RTW6582;282
//KWQ7044;251
//GFE1102;305
//HAY8123;428
//FYG9200;199
//NDN6548;126
//ART7990;290
//KBV6656;228
//FNM8486;363
//KVC0840;209
//RDM3543;325 

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Carros
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		//variáveis utlizadas
		int soma = 0; 
		int media = 0;
		
		void LeituraClick(object sender, EventArgs e)
		{
			//botão de leitura carros.txt
			panel1.Visible = false;
			rtbInput.LoadFile("carros.txt",RichTextBoxStreamType.PlainText);
		}
		void ProcessamentoClick(object sender, EventArgs e)
		{	
			//a média em km
			for (int i = 0; i < 17; i++)
        	{ 
	            string linha_placas = rtbInput.Lines[i]; 
	            string [] carro = linha_placas.Split (';');  
	            string s1 = carro[0];
	            
	            int n1 = int.Parse(carro[1]);
	           	int n2 = soma + n1; 	
	           	soma = n2;
	           	int n3 = n2/17; 
	       	    
	           	media = n3;
	           	media1.Text = "Média em km : "+media; 
			} 
			
			for (int i = 0; i < 17; i++)  
			{ 
				//cálculo dos carrros econômicos
				string linha_placas = rtbInput.Lines[i]; 
	            string [] carro = linha_placas.Split (';'); 
	            string s1 = carro[0]; 
	            
	            int n1 = int.Parse(carro[1]);

            	if (n1>media)  
            	{ 
            		rtbOutput.Text += s1+"\n"; 
            	} 
			} 
		}
		void SalvarClick(object sender, EventArgs e)
		{
			//Salvamento do economicos.txt
			rtbOutput.SaveFile("economicos.txt",RichTextBoxStreamType.PlainText); 
			MessageBox.Show("Arquivo salvo."); 
		}
	}
}
