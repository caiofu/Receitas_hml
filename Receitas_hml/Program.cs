using Newtonsoft.Json;
using Receitas_hml.Forms;

namespace Receitas_hml
{
	public static class Program
	{
    
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]

		static void Main()
		{
			
				// To customize application configuration such as set high DPI settings or default font,
				// see https://aka.ms/applicationconfiguration.
				ApplicationConfiguration.Initialize();
			Application.Run(new telaPrincipal());
		}
	}
}