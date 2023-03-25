using Newtonsoft.Json;
using Receitas_hml.Forms;

namespace Receitas_hml
{
	internal static class Program
	{
        //CRIANDO A LISTA PARA LIDAR COM AS RECEIRAS
        public static List<Receita> ListaDeReceitas = new List<Receita>();
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]

		static void Main()
		{
			//CARREGANDO DADOS DO ARQUIVO JSON PARA LISTA CASO TENHA DADOS
			dynamic objJsonCarrega = JsonConvert.DeserializeObject(File.ReadAllText(Arquivo.caminhoArquivo));

			if (File.Exists(Arquivo.caminhoArquivo) && objJsonCarrega.Count > 0)
			{
				foreach (var item in objJsonCarrega)
				{
					Receita auxReceita = new Receita();
					auxReceita.id = item.id;
					auxReceita.nomeReceita = item.nomeReceita;
					auxReceita.dificuldade = item.dificuldade;
					auxReceita.imagem = item.imagem;

                    //Loop para adicionar ingrediente
                    foreach (var ingr in item.ingredientes)
                    {
						auxReceita.ingredientes.Add(ingr.ToString());
                    }

					//Loop para adicionar preparo
					foreach (var prep in item.modoPreparo)
					{
						auxReceita.modoPreparo.Add(prep.ToString());
					}

					//Adicionando a lista
					ListaDeReceitas.Add(auxReceita);
				}

			}


				// To customize application configuration such as set high DPI settings or default font,
				// see https://aka.ms/applicationconfiguration.
				ApplicationConfiguration.Initialize();
			Application.Run(new telaPrincipal());
		}
	}
}