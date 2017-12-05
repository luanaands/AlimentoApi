using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Servico.Implementacao
{
    public class AlimentoServico : IAlimentoServico
    {
        public IAlimentoRepositorio AlimentoRepositorio { get; set; }

        #region IParametroServico Members

        void IAlimentoServico.Adicionar(Alimento item)
        {
            AlimentoRepositorio.Adicionar(item);
        }

        void IAlimentoServico.Editar(Alimento item)
        {
            AlimentoRepositorio.Editar(item);
        }

        void IAlimentoServico.Deletar(Alimento item)
        {
            AlimentoRepositorio.Deletar(item);
        }

        void IAlimentoServico.DeletarMuitos(Func<Alimento, bool> where)
        {
            AlimentoRepositorio.DeletarMuitos(where);
        }

        Alimento IAlimentoServico.ObterPorID(int Id)
        {
            return AlimentoRepositorio.ObterPorID(Id);
        }

        Alimento IAlimentoServico.ObterPorDescricao(Func<Alimento, bool> where)
        {
            return AlimentoRepositorio.ObterPorDescricao(where);
        }

        Alimento IAlimentoServico.ObterPrimeiro()
        {
            return AlimentoRepositorio.ObterPrimeiro();
        }

        Alimento IAlimentoServico.ObterPrimeiro(Func<Alimento, bool> where)
        {
            return AlimentoRepositorio.ObterPrimeiro(where);
        }

        IEnumerable<Alimento> IAlimentoServico.ListarTudo()
        {
            return AlimentoRepositorio.ListarTudo();
        }

        IQueryable<Alimento> IAlimentoServico.GetQueryable()
        {
            return AlimentoRepositorio.GetQueryable();
        }

        IEnumerable<Alimento> IAlimentoServico.ListarMuitos(Func<Alimento, bool> where)
        {
            return AlimentoRepositorio.ListarMuitos(where);
        }

        #endregion
    }
}