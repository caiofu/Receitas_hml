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
			List<String> ingredientes = new List<String>();
			List<String> modoDePreparo = new List<String>();
			Receita novaReceita = new Receita("teste","caminho",ingredientes, false, "facil", modoDePreparo);
			ListaDeReceitas.Add(novaReceita);
			Arquivo.CriaArquivo(ListaDeReceitas);
			

		// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new telaPrincipal());
		}
	}
}