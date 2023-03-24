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
	public partial class adicionarReceita : BaseForm
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

		private void adicionarReceita_Load(object sender, EventArgs e)
		{

		}

		private void btnAdicionarReceita_Click(object sender, EventArgs e)
		{
			if(ValidaCampos() == true)
			{
				//Salvando em arquivo
			}
			
		}

		private bool ValidaCampos()
		{
			bool retorno = true;
			errorProviderValidaReceita.Clear();

			
			
			//Validando
			if (txtBoxNomeReceita.Text.Trim() == "")
			{
				errorProviderValidaReceita.SetIconPadding(txtBoxNomeReceita, 4);
				errorProviderValidaReceita.SetError(txtBoxNomeReceita,"Digite o nome da receita");
				retorno = false;
			}

			if(lstBoxIngredientes.Items.Count <= 0) 
			{
				errorProviderValidaReceita.SetIconPadding(lstBoxIngredientes, 4);
				errorProviderValidaReceita.SetError(lstBoxIngredientes, "Digite pelo menos um ingrediente!");
				retorno = false;
			}

			if(lstBoxPreparo.Items.Count <= 0)
			{
				errorProviderValidaReceita.SetIconPadding(lstBoxPreparo, 4);
				errorProviderValidaReceita.SetError(lstBoxPreparo, "Digite pelo menos um modo de preparo!");
				retorno = false;
			}

			if(picBoxFotoReceita.Image == null)
			{
				errorProviderValidaReceita.SetIconPadding(picBoxFotoReceita, 4);
				errorProviderValidaReceita.SetError(picBoxFotoReceita, "Escolha uma imagem!");
				retorno = false;
			}

			return retorno;
		}

	}
}
