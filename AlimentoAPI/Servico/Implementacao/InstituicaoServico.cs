using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Servico.Implementacao
{
    public class InstituicaoServico : IInstituicaoServico
    {

        public IInstituicaoRepositorio InstituicaoRepositorio { get; set; }

        #region IParametroServico Members

        void IInstituicaoServico.Adicionar(Instituicao item)
        {
            InstituicaoRepositorio.Adicionar(item);
        }

        void IInstituicaoServico.Editar(Instituicao item)
        {
            InstituicaoRepositorio.Editar(item);
        }

        void IInstituicaoServico.Deletar(Instituicao item)
        {
            InstituicaoRepositorio.Deletar(item);
        }

        void IInstituicaoServico.DeletarMuitos(Func<Instituicao, bool> where)
        {
            InstituicaoRepositorio.DeletarMuitos(where);
        }

        Instituicao IInstituicaoServico.ObterPorID(int Id)
        {
            return InstituicaoRepositorio.ObterPorID(Id);
        }

        Instituicao IInstituicaoServico.ObterPorDescricao(Func<Instituicao, bool> where)
        {
            return InstituicaoRepositorio.ObterPorDescricao(where);
        }

        Instituicao IInstituicaoServico.ObterPrimeiro()
        {
            return InstituicaoRepositorio.ObterPrimeiro();
        }

        Instituicao IInstituicaoServico.ObterPrimeiro(Func<Instituicao, bool> where)
        {
            return InstituicaoRepositorio.ObterPrimeiro(where);
        }

        IEnumerable<Instituicao> IInstituicaoServico.ListarTudo()
        {
            return InstituicaoRepositorio.ListarTudo();
        }

        IQueryable<Instituicao> IInstituicaoServico.GetQueryable()
        {
            return InstituicaoRepositorio.GetQueryable();
        }

        IEnumerable<Instituicao> IInstituicaoServico.ListarMuitos(Func<Instituicao, bool> where)
        {
            return InstituicaoRepositorio.ListarMuitos(where);
        }

        #endregion

    }
}