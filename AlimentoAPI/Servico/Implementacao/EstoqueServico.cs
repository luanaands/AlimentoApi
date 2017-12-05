using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Servico.Implementacao
{
    public class EstoqueServico : IEstoqueServico
    {
        public IEstoqueRepositorio EstoqueRepositorio { get; set; }

        #region IParametroServico Members

        void IEstoqueServico.Adicionar(Estoque item)
        {
            EstoqueRepositorio.Adicionar(item);
        }

        void IEstoqueServico.Editar(Estoque item)
        {
            EstoqueRepositorio.Editar(item);
        }

        void IEstoqueServico.Deletar(Estoque item)
        {
            EstoqueRepositorio.Deletar(item);
        }

        void IEstoqueServico.DeletarMuitos(Func<Estoque, bool> where)
        {
            EstoqueRepositorio.DeletarMuitos(where);
        }

        Estoque IEstoqueServico.ObterPorID(int Id)
        {
            return EstoqueRepositorio.ObterPorID(Id);
        }

        Estoque IEstoqueServico.ObterPorDescricao(Func<Estoque, bool> where)
        {
            return EstoqueRepositorio.ObterPorDescricao(where);
        }

        Estoque IEstoqueServico.ObterPrimeiro()
        {
            return EstoqueRepositorio.ObterPrimeiro();
        }

        Estoque IEstoqueServico.ObterPrimeiro(Func<Estoque, bool> where)
        {
            return EstoqueRepositorio.ObterPrimeiro(where);
        }

        IEnumerable<Estoque> IEstoqueServico.ListarTudo()
        {
            return EstoqueRepositorio.ListarTudo();
        }

        IQueryable<Estoque> IEstoqueServico.GetQueryable()
        {
            return EstoqueRepositorio.GetQueryable();
        }

        IEnumerable<Estoque> IEstoqueServico.ListarMuitos(Func<Estoque, bool> where)
        {
            return EstoqueRepositorio.ListarMuitos(where);
        }

        #endregion

    }
}