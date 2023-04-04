using Receitas_hml.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas_hml
{
	public class Receita
	{
		public int id { get; set; }
		public String nomeReceita { get; set; }
		
		public String imagem { get; set; } 
		public List<String> ingredientes = new List<String>();
		public bool favorito = false; //padrão
		public String dificuldade { get; set; }
		public List<String> modoPreparo = new List<String>();
		

		//CONSTRUTOR
		public Receita() { }
		public Receita(int id,String nomeReceita, String imagem, List<String> ingredientes, bool favorito, string dificuldade,List<String> modoPreparo)
        {
			this.id = id;
			this.nomeReceita = nomeReceita;
			this.imagem = imagem;
			this.ingredientes = ingredientes;
			this.favorito = favorito;	
			this.dificuldade = dificuldade;
			this.modoPreparo = modoPreparo;

			

        }

		

		public void EditarReceita() //botão "Editar" presente em algum Form deverá chamar esta função
		{ //Não colocarei como argumento um objeto receita, pois ao clicar no botão "Editar",
		  //a chamada deve procurar a lista de objetos receitas, selecionar a receita e chamar a função, logo poderemos editar os campos com "this.nome" por exemplo
		  
			//Chama formulário de edição dos campos do objeto receita, os valores dos txtBox atualizarão os atributos da receita.
		}

		public  void ExcluirReceita()
        {

        }
	}
}
