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
		public String autor { get; set; }
		public String imagem { get; set; } 
		public List<String> ingredientes = new List<String>();
		public bool favorito = false; //padrão
		public String dificuldade { get; set; }
		public List<String> modoPreparo = new List<String>();
		

		//CONSTRUTOR
		public Receita() { }
		public Receita(int id, String nomeReceita, String imagem, List<String> ingredientes, bool favorito, string dificuldade, List<String> modoPreparo, string autor)
        {
            this.id = id;
            this.nomeReceita = nomeReceita;
            this.imagem = imagem;
            this.ingredientes = ingredientes;
            this.favorito = favorito;
            this.dificuldade = dificuldade;
            this.modoPreparo = modoPreparo;
            this.autor = autor;
        }



        public void EditarReceita() { 
		}

		public  void ExcluirReceita()
        {

        }
	}
}
