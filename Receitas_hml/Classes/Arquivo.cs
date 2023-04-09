using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;


namespace Receitas_hml
{
	public static class Arquivo
	{
		public static string caminhoArquivo = "bdReceitas.json";
		public static string caminhoDiretorioImg = "imgReceitas";

		//teste
		public static List<Receita> ListaDeReceitas = new List<Receita>();

		//METODOS
		public static void PreparaArquivo()
		{
			//### PREPARANDO ARQUIVOS E DIRETORIOS ##//
			if (File.Exists(Arquivo.caminhoArquivo) == false)
			{
				string json = JsonConvert.SerializeObject(ListaDeReceitas, Formatting.Indented); //Formatting.Indented para ficar organizado
				File.WriteAllText(Arquivo.caminhoArquivo, json);
			}

			if (!Directory.Exists(Arquivo.caminhoDiretorioImg))
			{
				Directory.CreateDirectory(Arquivo.caminhoDiretorioImg);
			}
			//## ------------------- ##//

			//CARREGANDO DADOS DO ARQUIVO JSON PARA LISTA CASO TENHA DADOS
			dynamic objJsonCarrega = JsonConvert.DeserializeObject(File.ReadAllText(Arquivo.caminhoArquivo));

			if (File.Exists(Arquivo.caminhoArquivo) && objJsonCarrega.Count > 0) //TRATAR CASO ARQUIVO JSON ESTEJA EM FORMATO INVALIDO
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

		}
		public static void CriaArquivo(List<Receita> ListaDeReceitas)
		{
			/*//CRIA O ARQUIVO JSON CASO ELE NÃO EXISTA
			if (File.Exists(caminhoArquivo) == false)
			{
				string json = JsonConvert.SerializeObject(ListaDeReceitas, Formatting.Indented); //Formatting.Indented para ficar organizado
				File.WriteAllText(caminhoArquivo, json);
			}*/
			string json = JsonConvert.SerializeObject(ListaDeReceitas, Formatting.Indented); //Formatting.Indented para ficar organizado
			File.WriteAllText(caminhoArquivo, json);

		}

		public static dynamic LerAquivo()
        {
			dynamic objJsonCarrega = JsonConvert.DeserializeObject(File.ReadAllText(Arquivo.caminhoArquivo));
			return objJsonCarrega;
		}

		public static void RemoveReceita()
		{
			//dynamic objJson = JsonConvert.DeserializeObject(File.ReadAllText(caminhoArquivo));
			//Remove o contato
			// objJson.RemoveAt(idContato);

			

			//Remonta o arquivo json
			//File.WriteAllText(caminhoArquivo, JsonConvert.SerializeObject(objJson, Formatting.Indented));
		}
	}
}
