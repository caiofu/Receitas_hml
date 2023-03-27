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
    public partial class detalhesReceita : BaseForm
    {
        public detalhesReceita()
        {
            InitializeComponent();

            Receita receita = new Receita();
            // Criar a lista de itens que deseja adicionar
            receita.ingredientes.Add("Ingrediente 0");
            receita.ingredientes.Add("Ingrediente 1");
            receita.ingredientes.Add("Ingrediente 2");
            receita.ingredientes.Add("Ingrediente 3");
            receita.ingredientes.Add("Ingrediente 4");
            List<string> ingredientes = new List<string>();
            ingredientes = receita.ingredientes;


            // Adicionar itens ao ListView
            foreach (string ingrediente in ingredientes)
            {
                listView1.Items.Add(ingrediente);
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
