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
            // Criar a lista de itens que deseja adicionar
            List<string> itens = new List<string>();
            itens.Add("Item 1");
            itens.Add("Item 2");
            itens.Add("Item 3");


            // Adicionar itens ao ListView
            foreach (string item in itens)
            {
                listView1.Items.Add(item);
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
    }
}
