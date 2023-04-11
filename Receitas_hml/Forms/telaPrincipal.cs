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
            CarregarReceitas(Arquivo.ListaDeReceitas);
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            cboxFiltros.SelectedIndex = 0;
            Arquivo.PreparaArquivo();
            CarregarReceitas(Arquivo.ListaDeReceitas);
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
            if (filtro == "TODOS")
            {
                if(entrada == "")
                {
                    auxListaReceitas = Arquivo.ListaDeReceitas
                        .Select(r => r).ToList();
                }
                else {
                    auxListaReceitas = Arquivo.ListaDeReceitas
                       .Where(r => removeAcentos(r.nomeReceita).Contains(removeAcentos(entrada)) ||
                           r.ingredientes.Any(i => removeAcentos(i.ToLower()) == entrada) ||
                           removeAcentos(r.dificuldade).Contains(removeAcentos(entrada)))
                        .Select(r => r).ToList();

                }
            }
            else if (filtro == "TITULO")
            {

                auxListaReceitas = Arquivo.ListaDeReceitas
                    .Where(r => removeAcentos(r.nomeReceita).Contains(removeAcentos(entrada)))
                    .Select(r => r).ToList();
            }
            else if (filtro == "INGREDIENTE")
            {
                auxListaReceitas = Arquivo.ListaDeReceitas
                    .Where(r => r.ingredientes.Any(i => removeAcentos(i.ToLower()) == entrada))
                    .Select(r => r).ToList();
            }
            else if (filtro == "DIFICULDADE")
            {
                auxListaReceitas = Arquivo.ListaDeReceitas
                    .Where(r => removeAcentos(r.dificuldade).Contains(removeAcentos(entrada)))
                    .Select(r => r).ToList();
            }
            /*else if(filtro == "FAVORITOS")
            { Equals(removeAcentos(entrada.ToLower())))
                auxListaReceitas = Program.ListaDeReceitas
                    .Where(r => r.favorito = true)
                    .Select(r => r).ToList();
            }*/

            CarregarReceitas(auxListaReceitas);

        }

        public void CarregarReceitas(List<Receita> ListaDeReceitas)
        {
            flowLayoutPanelReceitas.Controls.Clear();
            int qtdReceitas = Arquivo.ListaDeReceitas.Count;

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

        public static String removeAcentos(String texto)
        {
            String comAcentos = "‰·‚‡„ÈÍÎËÌÓÔÏˆÛÙÚı¸˙˚˘«Á";
            String semAcentos = "aaaaaeeeeiiiiooooouuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto.ToLower();
        }

        private void cboxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}