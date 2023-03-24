namespace Receitas_hml
{
    public partial class telaPrincipal : BaseForm
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnOnClickBuscaReceita(object sender, EventArgs e)
        {
            List<Receita> ListadeReceitas = new List<Receita>();

            foreach(var LiReceitas in ListadeReceitas)
            {
                if(txtBuscaReceita.Text == "")
                {
                    MessageBox.Show("Digite algo se deseja pesquisar!");
                }
                else if (LiReceitas.nome.Contains(txtBuscaReceita.Text))
                {
                    
                }
                
            }

        }

       
    }
}