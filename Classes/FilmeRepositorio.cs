using System;
using System.Collections.Generic;
using System.Text;
using ProjetoApp.Interfaces;

namespace ProjetoApp
{
		public class FilmeRepositorio : IRepositorioFilme<Filme>
		{
			private List<Filme> listaFilme = new List<Filme>();
			public void Atualiza(int id, Filme objeto)
			{
				listaFilme[id] = objeto;
			}

			public void Exclui(int id)
			{
				listaFilme[id].Excluir();
			}

			public void Insere(Filme objeto)
			{
				listaFilme.Add(objeto);
			}

			public List<Filme> Lista()
			{
				return listaFilme;
			}

			public int ProximoId()
			{
				return listaFilme.Count;
			}

			public Filme RetornaPorId(int id)
			{
				return listaFilme[id];
			}
		}

	}


