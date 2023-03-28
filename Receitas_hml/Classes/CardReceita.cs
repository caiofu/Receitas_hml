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
        public CardReceita(Receita receitaAtual)
        {
            InitializeComponent();

            lbNomeReceita.Text = receitaAtual.nomeReceita;
            lbNivelDificuldade.Text = receitaAtual.dificuldade;
        }
        public CardReceita()
        {
            InitializeComponent();
            lbDefault.Text = "Adicione uma receita";
            pctBoxImagem.Visible = false;
            lbNomeReceita.Visible = false;
            lbDificuldade.Visible = false;
            lbNivelDificuldade.Visible = false;
        }

        private void ReceitaEscolhida_Click(object sender, EventArgs e)
        {
            //Abrir form da receita
        }
    }
}
