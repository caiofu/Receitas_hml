using Receitas_hml.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receitas_hml.Classes
{
	public partial class CardReceita : UserControl
	{
		private int idReceita { get; set; }
		public CardReceita(Receita receitaAtual)
		{
			InitializeComponent();
			this.BorderStyle = BorderStyle.FixedSingle;
			lbNomeReceita.Text = receitaAtual.nomeReceita;
			lbNivelDificuldade.Text = receitaAtual.dificuldade;
			pctBoxImagem.ImageLocation = receitaAtual.imagem;
			idReceita = receitaAtual.id;
		}
		public CardReceita()
		{
			InitializeComponent();
			this.Margin = new Padding(3, 90, 3, 3);
			lbDefault.Text = "Adicione uma receita";
			pctBoxImagem.Visible = false;
			lbNomeReceita.Visible = false;
			lbDificuldade.Visible = false;
			lbNivelDificuldade.Visible = false;
		}

		private void ReceitaEscolhida_Click(object sender, EventArgs e)
		{
			
			//Abrir form da receita
			detalhesReceita detalhesReceita = new detalhesReceita(this.idReceita);
			detalhesReceita.ShowDialog();
			
		}

		private void CardReceita_Load(object sender, EventArgs e)
		{

		}
	}
}
