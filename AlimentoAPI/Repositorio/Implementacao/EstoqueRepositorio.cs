using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {

        private IUnitOfWork _UntWork;


        public EstoqueRepositorio(IUnitOfWork UntWork)
        {
            _UntWork = UntWork;
        }

        #region EstoqueRepositorio Members

        public void Adicionar(Estoque item)
        {
            _UntWork.contexto.Estoque.Add(item);
            _UntWork.Commit();
        }

        public void Editar(Estoque item)
        {
            _UntWork.contexto.Entry(item).State = EntityState.Modified;
            _UntWork.Commit();
        }

        public void Deletar(Estoque item)
        {
            _UntWork.contexto.Estoque.Remove(item);
            _UntWork.Commit();
        }

        public void DeletarMuitos(Func<Estoque, bool> where)
        {
            _UntWork.contexto.Estoque.Where(where).ToList().ForEach(item => _UntWork.contexto.Estoque.Remove(item));
            _UntWork.Commit();
        }

        public Estoque ObterPorID(int Id)
        {
            return _UntWork.contexto.Estoque.Find(Id);
        }

        public Estoque ObterPorDescricao(Func<Estoque, bool> where)
        {
            return _UntWork.contexto.Estoque.Where(where).FirstOrDefault();
        }

        public Estoque ObterPrimeiro()
        {
            return _UntWork.contexto.Estoque.FirstOrDefault();
        }

        public Estoque ObterPrimeiro(Func<Estoque, bool> where)
        {
            return _UntWork.contexto.Estoque.Where(where).FirstOrDefault();
        }

        public IEnumerable<Estoque> ListarTudo()
        {
            return _UntWork.contexto.Estoque.ToList();
        }

        public IQueryable<Estoque> GetQueryable()
        {
            return _UntWork.contexto.Estoque;
        }

        public IEnumerable<Estoque> ListarMuitos(Func<Estoque, bool> where)
        {
            return _UntWork.contexto.Estoque.Where(where).ToList();
        }

        #endregion
    }
}