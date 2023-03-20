using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;


namespace Receitas_hml
{
	internal class Arquivo
	{
		public static string caminhoArquivo = "bdReceitas.json";

		//METODOS
		public static void CriaArquivo(List<Receita> ListaDeReceitas)
		{
			//CRIA O ARQUIVO JSON CASO ELE NÃO EXISTA
			if (File.Exists(caminhoArquivo) == false)
			{
				string json = JsonConvert.SerializeObject(ListaDeReceitas, Formatting.Indented); //Formatting.Indented para ficar organizado
				File.WriteAllText(caminhoArquivo, json);
			}
			
		}

		public static void RemoveContato(int idContato)
		{
			dynamic objJson = JsonConvert.DeserializeObject(File.ReadAllText(caminhoArquivo));
			//Remove o contato
			objJson.RemoveAt(idContato);

			

			//Remonta o arquivo json
			File.WriteAllText(caminhoArquivo, JsonConvert.SerializeObject(objJson, Formatting.Indented));
		}
	}
}
