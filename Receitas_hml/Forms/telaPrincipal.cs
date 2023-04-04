using Receitas_hml.Forms;
using Receitas_hml.Classes;
using Newtonsoft.Json;

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
            CarregarReceitas(Program.ListaDeReceitas);
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            
            CarregarReceitas(Program.ListaDeReceitas);
            /*
            int qtdReceitas = Program.ListaDeReceitas.Count;
            if (qtdReceitas != 0)
                foreach (Receita receita in Program.ListaDeReceitas)
                {
                    flowLayoutPanelReceitas.Controls.Add(new CardReceita(receita));
                }
            else
            {
                flowLayoutPanelReceitas.Controls.Add(new CardReceita());
            }*/
            //}
            
        }

        private void btnPesquisarReceita_Click(object sender, EventArgs e)
        {
            //dynamic listaReceitas = JsonConvert.DeserializeObject(Arquivo.caminhoArquivo)!;
            String filtro = cboxFiltros.SelectedItem.ToString()!;
            String entrada = txBoxPesquisaReceita.Text.ToString();
            List<Receita> auxListaReceitas = new List<Receita>();
            
            if(filtro == "TITULO")
            {
                auxListaReceitas = Program.ListaDeReceitas
                    .Where(r => r.nomeReceita.Contains(entrada))
                    .Select(r => r).ToList();
            }
            else if(filtro == "INGREDIENTE")
            {
                auxListaReceitas = Program.ListaDeReceitas
                    .Where(r => r.ingredientes.Any(i => i == entrada))
                    .Select(r => r).ToList();
            }
            else if(filtro == "DIFICULDADE")
            {
                auxListaReceitas = Program.ListaDeReceitas
                    .Where(r => r.dificuldade == entrada)
                    .Select(r => r).ToList();   
            }
            /*else if(filtro == "FAVORITOS")
            {
                auxListaReceitas = Program.ListaDeReceitas
                    .Where(r => r.favorito = true)
                    .Select(r => r).ToList();
            }*/

            CarregarReceitas(auxListaReceitas);

        }

        public void CarregarReceitas(List<Receita> ListaDeReceitas)
        {
            flowLayoutPanelReceitas.Controls.Clear();
            int qtdReceitas = Program.ListaDeReceitas.Count;

            if (qtdReceitas != 0)
            {
                foreach (Receita receita in ListaDeReceitas)
                {
                    flowLayoutPanelReceitas.Controls.Add(new CardReceita(receita));
                }
            }
            else
            {
                flowLayoutPanelReceitas.Controls.Add(new CardReceita());
            }
        }
    }
}