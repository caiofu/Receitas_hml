using Receitas_hml.Forms;
using Receitas_hml.Classes;

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

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            int qtdReceitas = Program.ListaDeReceitas.Count;
            if (qtdReceitas != 0)
                foreach (Receita receita in Program.ListaDeReceitas)
                {
                    flowLayoutPanelReceitas.Controls.Add(new CardReceita(receita));
                }
            else
            {
                flowLayoutPanelReceitas.Controls.Add(new CardReceita());
            }
        }
    }
}