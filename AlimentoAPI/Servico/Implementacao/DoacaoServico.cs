using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Servico.Implementacao
{
    public class DoacaoServico : IDoacaoServico
    {

        public IDoacaoRepositorio DoacaoRepositorio { get; set; }

        #region IParametroServico Members

        void IDoacaoServico.Adicionar(Doacao item)
        {
            DoacaoRepositorio.Adicionar(item);
        }

        void IDoacaoServico.Editar(Doacao item)
        {
            DoacaoRepositorio.Editar(item);
        }

        void IDoacaoServico.Deletar(Doacao item)
        {
            DoacaoRepositorio.Deletar(item);
        }

        void IDoacaoServico.DeletarMuitos(Func<Doacao, bool> where)
        {
            DoacaoRepositorio.DeletarMuitos(where);
        }

        Doacao IDoacaoServico.ObterPorID(int Id)
        {
            return DoacaoRepositorio.ObterPorID(Id);
        }

        Doacao IDoacaoServico.ObterPorDescricao(Func<Doacao, bool> where)
        {
            return DoacaoRepositorio.ObterPorDescricao(where);
        }

        Doacao IDoacaoServico.ObterPrimeiro()
        {
            return DoacaoRepositorio.ObterPrimeiro();
        }

        Doacao IDoacaoServico.ObterPrimeiro(Func<Doacao, bool> where)
        {
            return DoacaoRepositorio.ObterPrimeiro(where);
        }

        IEnumerable<Doacao> IDoacaoServico.ListarTudo()
        {
            return DoacaoRepositorio.ListarTudo();
        }

        IQueryable<Doacao> IDoacaoServico.GetQueryable()
        {
            return DoacaoRepositorio.GetQueryable();
        }

        IEnumerable<Doacao> IDoacaoServico.ListarMuitos(Func<Doacao, bool> where)
        {
            return DoacaoRepositorio.ListarMuitos(where);
        }

        #endregion
    }
}