using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class OrganizacoesFilantropicasRepositorio :IOrganizacoesFilantropicasRepositorio
    {
        private IUnitOfWork _UntWork;


        public OrganizacoesFilantropicasRepositorio(IUnitOfWork UntWork)
        {
            _UntWork = UntWork;
        }

        #region OrganizacoesFilantropicasRepositorio Members

        public void Adicionar(OrganizacoesFilantropicas item)
        {
            _UntWork.contexto.OrganizacoesFilantropicas.Add(item);
            _UntWork.Commit();
        }

        public void Editar(OrganizacoesFilantropicas item)
        {
            _UntWork.contexto.Entry(item).State = EntityState.Modified;
            _UntWork.Commit();
        }

        public void Deletar(OrganizacoesFilantropicas item)
        {
            _UntWork.contexto.OrganizacoesFilantropicas.Remove(item);
            _UntWork.Commit();
        }

        public void DeletarMuitos(Func<OrganizacoesFilantropicas, bool> where)
        {
            _UntWork.contexto.OrganizacoesFilantropicas.Where(where).ToList().ForEach(item => _UntWork.contexto.OrganizacoesFilantropicas.Remove(item));
            _UntWork.Commit();
        }

        public OrganizacoesFilantropicas ObterPorID(int Id)
        {
            return _UntWork.contexto.OrganizacoesFilantropicas.Find(Id);
        }

        public OrganizacoesFilantropicas ObterPorDescricao(Func<OrganizacoesFilantropicas, bool> where)
        {
            return _UntWork.contexto.OrganizacoesFilantropicas.Where(where).FirstOrDefault();
        }

        public OrganizacoesFilantropicas ObterPrimeiro()
        {
            return _UntWork.contexto.OrganizacoesFilantropicas.FirstOrDefault();
        }

        public OrganizacoesFilantropicas ObterPrimeiro(Func<OrganizacoesFilantropicas, bool> where)
        {
            return _UntWork.contexto.OrganizacoesFilantropicas.Where(where).FirstOrDefault();
        }

        public IEnumerable<OrganizacoesFilantropicas> ListarTudo()
        {
            return _UntWork.contexto.OrganizacoesFilantropicas.ToList();
        }

        public IQueryable<OrganizacoesFilantropicas> GetQueryable()
        {
            return _UntWork.contexto.OrganizacoesFilantropicas;
        }

        public IEnumerable<OrganizacoesFilantropicas> ListarMuitos(Func<OrganizacoesFilantropicas, bool> where)
        {
            return _UntWork.contexto.OrganizacoesFilantropicas.Where(where).ToList();
        }

        #endregion

    }
}