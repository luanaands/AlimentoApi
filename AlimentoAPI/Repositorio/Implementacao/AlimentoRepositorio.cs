using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class AlimentoRepositorio : IAlimentoRepositorio
    {
        private IUnitOfWork _UntWork;


        public AlimentoRepositorio(IUnitOfWork UntWork)
        {
            _UntWork = UntWork;
        }

        #region AlimentoRepositorio Members

        public void Adicionar(Alimento item)
        {
            _UntWork.contexto.Alimento.Add(item);
            _UntWork.Commit();
        }

        public void Editar(Alimento item)
        {
            _UntWork.contexto.Entry(item).State = EntityState.Modified;
            _UntWork.Commit();
        }

        public void Deletar(Alimento item)
        {
            _UntWork.contexto.Alimento.Remove(item);
            _UntWork.Commit();
        }

        public void DeletarMuitos(Func<Alimento, bool> where)
        {
            _UntWork.contexto.Alimento.Where(where).ToList().ForEach(item => _UntWork.contexto.Alimento.Remove(item));
            _UntWork.Commit();
        }

        public Alimento ObterPorID(int Id)
        {
            return _UntWork.contexto.Alimento.Find(Id);
        }

        public Alimento ObterPorDescricao(Func<Alimento, bool> where)
        {
            return _UntWork.contexto.Alimento.Where(where).FirstOrDefault();
        }

        public Alimento ObterPrimeiro()
        {
            return _UntWork.contexto.Alimento.FirstOrDefault();
        }

        public Alimento ObterPrimeiro(Func<Alimento, bool> where)
        {
            return _UntWork.contexto.Alimento.Where(where).FirstOrDefault();
        }

        public IEnumerable<Alimento> ListarTudo()
        {
            return _UntWork.contexto.Alimento.ToList();
        }

        public IQueryable<Alimento> GetQueryable()
        {
            return _UntWork.contexto.Alimento;
        }

        public IEnumerable<Alimento> ListarMuitos(Func<Alimento, bool> where)
        {
            return _UntWork.contexto.Alimento.Where(where).ToList();
        }

        #endregion
    }

}