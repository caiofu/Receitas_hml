using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receitas_hml
{
	public partial class detalhesReceita : Form
	{
		public detalhesReceita(int id)
		{
			InitializeComponent();
			id = id - 1;//Corrigindo para posição do vetor para facilitar

			//Titulo e informações da receita
			lbDetalhesTituloReceita.Text = Arquivo.ListaDeReceitas[id].nomeReceita;
			lbNomeAutor.Text = Arquivo.ListaDeReceitas[id].autor;
			lbDetalhesDificuldadeNumero.Text = Arquivo.ListaDeReceitas[id].dificuldade;
			Image fotoReceita = Image.FromFile(Arquivo.ListaDeReceitas[id].imagem);
			imgReceita.Image = fotoReceita;

			//Ingredientes
			foreach (string ingrediente in Arquivo.ListaDeReceitas[id].ingredientes)
			{
				listViewIngredientes.Items.Add(ingrediente);
			}

			//Modo de preparo
			foreach (String modoPreparo in Arquivo.ListaDeReceitas[id].modoPreparo)
			{
				listViewModoPreparo.Items.Add(modoPreparo);
			}



		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void grpDetalhesReceitaCorpo_Enter(object sender, EventArgs e)
		{

		}
	}
}
