using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoApp
{
    public class Filme : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Filme(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Genero:  { this.Genero} { Environment.NewLine}";
            retorno += $"Titulo:  {this.Titulo} {Environment.NewLine}";
            retorno += $"Descricao: {this.Descricao} {Environment.NewLine}";
            retorno += $"Ano de Inicio {this.Ano}";
            retorno += $"Excluido {this.Excluido}";

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }

   

}


