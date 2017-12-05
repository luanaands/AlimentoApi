using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Servico.Implementacao
{
    public class OrganizacoesFilantropicasServico : IOrganizacoesFilantropicasServico
    {

        public IOrganizacoesFilantropicasRepositorio OrganizacoesFilantropicasRepositorio { get; set; }

        #region IParametroServico Members

        void IOrganizacoesFilantropicasServico.Adicionar(OrganizacoesFilantropicas item)
        {
            OrganizacoesFilantropicasRepositorio.Adicionar(item);
        }

        void IOrganizacoesFilantropicasServico.Editar(OrganizacoesFilantropicas item)
        {
            OrganizacoesFilantropicasRepositorio.Editar(item);
        }

        void IOrganizacoesFilantropicasServico.Deletar(OrganizacoesFilantropicas item)
        {
            OrganizacoesFilantropicasRepositorio.Deletar(item);
        }

        void IOrganizacoesFilantropicasServico.DeletarMuitos(Func<OrganizacoesFilantropicas, bool> where)
        {
            OrganizacoesFilantropicasRepositorio.DeletarMuitos(where);
        }

        OrganizacoesFilantropicas IOrganizacoesFilantropicasServico.ObterPorID(int Id)
        {
            return OrganizacoesFilantropicasRepositorio.ObterPorID(Id);
        }

        OrganizacoesFilantropicas IOrganizacoesFilantropicasServico.ObterPorDescricao(Func<OrganizacoesFilantropicas, bool> where)
        {
            return OrganizacoesFilantropicasRepositorio.ObterPorDescricao(where);
        }

        OrganizacoesFilantropicas IOrganizacoesFilantropicasServico.ObterPrimeiro()
        {
            return OrganizacoesFilantropicasRepositorio.ObterPrimeiro();
        }

        OrganizacoesFilantropicas IOrganizacoesFilantropicasServico.ObterPrimeiro(Func<OrganizacoesFilantropicas, bool> where)
        {
            return OrganizacoesFilantropicasRepositorio.ObterPrimeiro(where);
        }

        IEnumerable<OrganizacoesFilantropicas> IOrganizacoesFilantropicasServico.ListarTudo()
        {
            return OrganizacoesFilantropicasRepositorio.ListarTudo();
        }

        IQueryable<OrganizacoesFilantropicas> IOrganizacoesFilantropicasServico.GetQueryable()
        {
            return OrganizacoesFilantropicasRepositorio.GetQueryable();
        }

        IEnumerable<OrganizacoesFilantropicas> IOrganizacoesFilantropicasServico.ListarMuitos(Func<OrganizacoesFilantropicas, bool> where)
        {
            return OrganizacoesFilantropicasRepositorio.ListarMuitos(where);
        }

        #endregion

    }
}