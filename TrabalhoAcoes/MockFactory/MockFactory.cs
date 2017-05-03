using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoAcoes.Controllers;
using TrabalhoAcoes.Models;

namespace TrabalhoAcoes.MockFactory
{
    public static class MockFactory
    {
        public static List<Acao> GerarListaAcoes(int numeroDeVezes)
        {
            List<Acao> acoes = new List<Acao>();

            for (int i = 0; i < numeroDeVezes; i++)
            {
                acoes.Add(new Acao()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Ação"
                });
            }

            return acoes;
        }

        public static List<Categoria> GerarListaCategorias(int numeroDeVezes)
        {
            List<Categoria> categorias = new List<Categoria>();

            for (int i = 0; i < numeroDeVezes; i++)
            {
                categorias.Add(new Categoria()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Categoria"
                });
            }

            return categorias;
        }

        public static List<Entidade> GerarListaEntidades(int numeroDeVezes)
        {
            List<Entidade> entidades = new List<Entidade>();

            for (int i = 0; i < numeroDeVezes; i++)
            {
                entidades.Add(new Entidade()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Categoria"
                });
            }

            return entidades;
        }
    }
}