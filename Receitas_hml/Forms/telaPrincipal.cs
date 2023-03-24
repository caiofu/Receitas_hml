using Receitas_hml.Forms;

namespace Receitas_hml
{
	public partial class telaPrincipal : BaseForm
	{
		public telaPrincipal()
		{
			InitializeComponent();
		}

		private void btnAdicionarReceita_Click(object sender, EventArgs e)
		{
			adicionarReceita addReceita = new adicionarReceita();
			addReceita.ShowDialog();
        }
	}
}