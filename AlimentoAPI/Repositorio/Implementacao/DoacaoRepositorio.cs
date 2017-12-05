using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class DoacaoRepositorio :IDoacaoRepositorio
    {
        private IUnitOfWork _UntWork;


        public DoacaoRepositorio(IUnitOfWork UntWork)
        {
            _UntWork = UntWork;
        }

        #region DoacaoRepositorio Members

        public void Adicionar(Doacao item)
        {
            _UntWork.contexto.Doacao.Add(item);
            _UntWork.Commit();
        }

        public void Editar(Doacao item)
        {
            _UntWork.contexto.Entry(item).State = EntityState.Modified;
            _UntWork.Commit();
        }

        public void Deletar(Doacao item)
        {
            _UntWork.contexto.Doacao.Remove(item);
            _UntWork.Commit();
        }

        public void DeletarMuitos(Func<Doacao, bool> where)
        {
            _UntWork.contexto.Doacao.Where(where).ToList().ForEach(item => _UntWork.contexto.Doacao.Remove(item));
            _UntWork.Commit();
        }

        public Doacao ObterPorID(int Id)
        {
            return _UntWork.contexto.Doacao.Find(Id);
        }

        public Doacao ObterPorDescricao(Func<Doacao, bool> where)
        {
            return _UntWork.contexto.Doacao.Where(where).FirstOrDefault();
        }

        public Doacao ObterPrimeiro()
        {
            return _UntWork.contexto.Doacao.FirstOrDefault();
        }

        public Doacao ObterPrimeiro(Func<Doacao, bool> where)
        {
            return _UntWork.contexto.Doacao.Where(where).FirstOrDefault();
        }

        public IEnumerable<Doacao> ListarTudo()
        {
            return _UntWork.contexto.Doacao.ToList();
        }

        public IQueryable<Doacao> GetQueryable()
        {
            return _UntWork.contexto.Doacao;
        }

        public IEnumerable<Doacao> ListarMuitos(Func<Doacao, bool> where)
        {
            return _UntWork.contexto.Doacao.Where(where).ToList();
        }

        #endregion

    }
}