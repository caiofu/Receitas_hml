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
			if(  txtBoxIngredientes.Text.Trim() != "" )
			{
                lstBoxIngredientes.Items.Add(txtBoxIngredientes.Text);
                txtBoxIngredientes.Clear();
            }
			else
            {
				MessageBox.Show("VOCÊ NÃO PODE ADICIONAR CAMPOS VAZIOS!");
			}

		}

		private void btnRemoverIngrediente_Click(object sender, EventArgs e)
		{
			//Remove o item selecionado do lixtbox
			if(lstBoxIngredientes.Items.Count > 0 && lstBoxIngredientes.SelectedIndex > -1)
			{
                lstBoxIngredientes.Items.RemoveAt(lstBoxIngredientes.SelectedIndex);
            }
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnAdicionarPreparo_Click(object sender, EventArgs e)
		{
			if(txtBoxPreparo.Text.Trim() != "")
            {
				lstBoxPreparo.Items.Add(txtBoxPreparo.Text);
				txtBoxPreparo.Clear();
			}
			else
            {
				MessageBox.Show("VOCÊ NÃO PODE ADICIONAR CAMPOS VAZIOS!");
            }
			
		}

		private void btnRemoverPreparo_Click(object sender, EventArgs e)
		{
			//Remove o item selecionado do lixtbox
			if (lstBoxPreparo.Items.Count > 0 && lstBoxPreparo.SelectedIndex > -1)
			{
				lstBoxPreparo.Items.RemoveAt(lstBoxPreparo.SelectedIndex);
			}
		}

		private void btnAdicionaFotoReceita_Click(object sender, EventArgs e)
		{
			OpenFileDialog imagem = new OpenFileDialog();
			imagem.Filter = "Imagem JPG | *.jpg";
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
			if (ValidaCampos() == true)
			{
				//Salvando o indice
				int indiceReceita;
				if (Arquivo.ListaDeReceitas.Count() == 0)
                {
					indiceReceita = 0;
                }
				else
                {
					indiceReceita = Arquivo.ListaDeReceitas.Count() + 1;
				}
				//Salvando a imagem
				String caminho = "imgReceitas/receita_id_" + indiceReceita + ".jpg";
				Image image = Image.FromFile(picBoxFotoReceita.ImageLocation); //Pega aonde esta a imagem
				image.Save(caminho);

				//Adicionando modo de preparo e ingredientes a lista deles
				List<String> ingredientes = new List<String>();
				List<String> modoDePreparo = new List<String>();

				foreach (var item in lstBoxIngredientes.Items)
				{
					ingredientes.Add(item.ToString());
				}
				
				foreach (var item in lstBoxPreparo.Items)
				{
					modoDePreparo.Add(item.ToString());
				}

				//Dificuldade
				String dificuldade;
				switch (tckBarDificuldade.Value)
				{
					case 1:
						dificuldade = "Fácil";
						break;
						case 2:
						dificuldade = "Moderada";
						break;
						case 3:
						dificuldade = "Dificil";
						break;
					default:
						dificuldade = "Fácil";
						break;
				}

				Receita novaReceita = new Receita(indiceReceita, txtBoxNomeReceita.Text, caminho, ingredientes, false, dificuldade, modoDePreparo, txtBoxAutor.Text);
				Arquivo.ListaDeReceitas.Add(novaReceita);


				Arquivo.CriaArquivo(Arquivo.ListaDeReceitas);

				//VERIFICA SE O ARQUIVO FOI SALVO NO JSON.
				dynamic objJson = Arquivo.LerAquivo();
				if (Arquivo.ListaDeReceitas.Count == objJson.Count)
                {
					if (MessageBox.Show("Receita Salva!") == DialogResult.OK)
					{
						//((telaPrincipal)ParentForm).CarregarReceitas(Program.ListaDeReceitas);
						this.Close();
					}
				}
				else
                {
					MessageBox.Show("Erro! Sua receita não foi salva");
                }
					

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
				errorProviderValidaReceita.SetError(txtBoxNomeReceita, "Digite o nome da receita");
				retorno = false;
			}

			if (lstBoxIngredientes.Items.Count <= 0)
			{
				errorProviderValidaReceita.SetIconPadding(lstBoxIngredientes, 4);
				errorProviderValidaReceita.SetError(lstBoxIngredientes, "Digite pelo menos um ingrediente!");
				retorno = false;
			}

			if (lstBoxPreparo.Items.Count <= 0)
			{
				errorProviderValidaReceita.SetIconPadding(lstBoxPreparo, 4);
				errorProviderValidaReceita.SetError(lstBoxPreparo, "Digite pelo menos um modo de preparo!");
				retorno = false;
			}

			if (picBoxFotoReceita.Image == null)
			{
				errorProviderValidaReceita.SetIconPadding(picBoxFotoReceita, 4);
				errorProviderValidaReceita.SetError(picBoxFotoReceita, "Escolha uma imagem!");
				retorno = false;
			}

			if(txtBoxAutor.Text.Trim() == "")
            {
				errorProviderValidaReceita.SetIconPadding(txtBoxAutor, 4);
				errorProviderValidaReceita.SetError(txtBoxAutor, "Digite o nome do autor");
				retorno = false;
			}

			return retorno;
		}

		private void tckBarDificuldade_Scroll(object sender, EventArgs e)
		{
			if (tckBarDificuldade.Value == 1)
			{
				lbDificuldadeMensagem.ForeColor = Color.LimeGreen;
				lbDificuldadeMensagem.Text = "Fácil";
			}
			else if (tckBarDificuldade.Value == 2)
			{
				lbDificuldadeMensagem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff844d");
				lbDificuldadeMensagem.Text = "Moderado";
			}
			else if (tckBarDificuldade.Value == 3)
			{
				lbDificuldadeMensagem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f92d41");
				lbDificuldadeMensagem.Text = "Dificil";
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

        private void button1_Click(object sender, EventArgs e)
        {
			
        }

     
    }
}
