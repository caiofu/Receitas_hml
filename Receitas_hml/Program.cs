namespace Receitas_hml
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//CRIANDO A LISTA PARA LIDAR COM AS RECEIRAS
			List<Receita> ListaDeReceitas= new List<Receita>();

			//CRIA O ARQUIVO JSON CASO ELE N�O EXISTA
			if(File.Exists(Arquivo.caminhoArquivo) == false)
			{
				Arquivo.CriaArquivo(ListaDeReceitas);
			}

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new telaPrincipal());
		}
	}
}