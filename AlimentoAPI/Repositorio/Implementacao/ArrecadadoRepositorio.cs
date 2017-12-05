using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class ArrecadadoRepositorio : IArrecadadoRepositorio
    {
        private IUnitOfWork _UntWork;


        public ArrecadadoRepositorio(IUnitOfWork UntWork)
        {
            _UntWork = UntWork;
        }

        #region ArrecadadoRepositorio Members

        public void Adicionar(Arrecadado item)
        {
            _UntWork.contexto.Arrecadado.Add(item);
            _UntWork.Commit();
        }

        public void Editar(Arrecadado item)
        {
            _UntWork.contexto.Entry(item).State = EntityState.Modified;
            _UntWork.Commit();
        }

        public void Deletar(Arrecadado item)
        {
            _UntWork.contexto.Arrecadado.Remove(item);
            _UntWork.Commit();
        }

        public void DeletarMuitos(Func<Arrecadado, bool> where)
        {
            _UntWork.contexto.Arrecadado.Where(where).ToList().ForEach(item => _UntWork.contexto.Arrecadado.Remove(item));
            _UntWork.Commit();
        }

        public Arrecadado ObterPorID(int Id)
        {
            return _UntWork.contexto.Arrecadado.Find(Id);
        }

        public Arrecadado ObterPorDescricao(Func<Arrecadado, bool> where)
        {
            return _UntWork.contexto.Arrecadado.Where(where).FirstOrDefault();
        }

        public Arrecadado ObterPrimeiro()
        {
            return _UntWork.contexto.Arrecadado.FirstOrDefault();
        }

        public Arrecadado ObterPrimeiro(Func<Arrecadado, bool> where)
        {
            return _UntWork.contexto.Arrecadado.Where(where).FirstOrDefault();
        }

        public IEnumerable<Arrecadado> ListarTudo()
        {
            return _UntWork.contexto.Arrecadado.ToList();
        }

        public IQueryable<Arrecadado> GetQueryable()
        {
            return _UntWork.contexto.Arrecadado;
        }

        public IEnumerable<Arrecadado> ListarMuitos(Func<Arrecadado, bool> where)
        {
            return _UntWork.contexto.Arrecadado.Where(where).ToList();
        }

        #endregion

    }
}