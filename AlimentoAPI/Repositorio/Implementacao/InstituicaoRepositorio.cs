using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class InstituicaoRepositorio : IInstituicaoRepositorio
    {
        private IUnitOfWork _UntWork;


        public InstituicaoRepositorio(IUnitOfWork UntWork)
        {
            _UntWork = UntWork;
        }

        #region InstituicaoRepositorio Members

        public void Adicionar(Instituicao item)
        {
            _UntWork.contexto.Instituicao.Add(item);
            _UntWork.Commit();
        }

        public void Editar(Instituicao item)
        {
            _UntWork.contexto.Entry(item).State = EntityState.Modified;
            _UntWork.Commit();
        }

        public void Deletar(Instituicao item)
        {
            _UntWork.contexto.Instituicao.Remove(item);
            _UntWork.Commit();
        }

        public void DeletarMuitos(Func<Instituicao, bool> where)
        {
            _UntWork.contexto.Instituicao.Where(where).ToList().ForEach(item => _UntWork.contexto.Instituicao.Remove(item));
            _UntWork.Commit();
        }

        public Instituicao ObterPorID(int Id)
        {
            return _UntWork.contexto.Instituicao.Find(Id);
        }

        public Instituicao ObterPorDescricao(Func<Instituicao, bool> where)
        {
            return _UntWork.contexto.Instituicao.Where(where).FirstOrDefault();
        }

        public Instituicao ObterPrimeiro()
        {
            return _UntWork.contexto.Instituicao.FirstOrDefault();
        }

        public Instituicao ObterPrimeiro(Func<Instituicao, bool> where)
        {
            return _UntWork.contexto.Instituicao.Where(where).FirstOrDefault();
        }

        public IEnumerable<Instituicao> ListarTudo()
        {
            return _UntWork.contexto.Instituicao.ToList();
        }

        public IQueryable<Instituicao> GetQueryable()
        {
            return _UntWork.contexto.Instituicao;
        }

        public IEnumerable<Instituicao> ListarMuitos(Func<Instituicao, bool> where)
        {
            return _UntWork.contexto.Instituicao.Where(where).ToList();
        }

        #endregion
    }
}