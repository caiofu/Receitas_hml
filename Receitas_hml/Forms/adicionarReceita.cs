using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receitas_hml.Forms
{
	public partial class adicionarReceita : Form
	{
		public adicionarReceita()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnAdicionarIngredientes_Click(object sender, EventArgs e)
		{
			String ingrediente = txtBoxIngredientes.Text;
			lstBoxIngredientes.Items.Add(ingrediente);
		}

		private void btnRemoverIngrediente_Click(object sender, EventArgs e)
		{
			//Remove o item selecionado do lixtbox
			lstBoxIngredientes.Items.RemoveAt(lstBoxIngredientes.SelectedIndex);
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnAdicionarPreparo_Click(object sender, EventArgs e)
		{
			lstBoxPreparo.Items.Add(txtBoxPreparo.Text);
		}

		private void btnAdicionaFotoReceita_Click(object sender, EventArgs e)
		{
			OpenFileDialog imagem = new OpenFileDialog();
			imagem.Filter = "Imagem JPG | *.png";
			DialogResult respota = imagem.ShowDialog();

			//Valida se carregou corretamente
			if (respota == DialogResult.OK)
			{
				picBoxFotoReceita.ImageLocation = imagem.FileName;
				
			}
		}
	}
}
