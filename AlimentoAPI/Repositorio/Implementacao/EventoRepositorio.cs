using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Repositorio.Implementacao
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private IUnitOfWork _UntWork;


        public EventoRepositorio(IUnitOfWork UntWork)
        {
            _UntWork = UntWork;
        }

        #region EventoRepositorio Members

        public void Adicionar(Evento item)
        {
            _UntWork.contexto.Evento.Add(item);
            _UntWork.Commit();
        }

        public void Editar(Evento item)
        {
            _UntWork.contexto.Entry(item).State = EntityState.Modified;
            _UntWork.Commit();
        }

        public void Deletar(Evento item)
        {
            _UntWork.contexto.Evento.Remove(item);
            _UntWork.Commit();
        }

        public void DeletarMuitos(Func<Evento, bool> where)
        {
            _UntWork.contexto.Evento.Where(where).ToList().ForEach(item => _UntWork.contexto.Evento.Remove(item));
            _UntWork.Commit();
        }

        public Evento ObterPorID(int Id)
        {
            return _UntWork.contexto.Evento.Find(Id);
        }

        public Evento ObterPorDescricao(Func<Evento, bool> where)
        {
            return _UntWork.contexto.Evento.Where(where).FirstOrDefault();
        }

        public Evento ObterPrimeiro()
        {
            return _UntWork.contexto.Evento.FirstOrDefault();
        }

        public Evento ObterPrimeiro(Func<Evento, bool> where)
        {
            return _UntWork.contexto.Evento.Where(where).FirstOrDefault();
        }

        public IEnumerable<Evento> ListarTudo()
        {
            return _UntWork.contexto.Evento.ToList();
        }

        public IQueryable<Evento> GetQueryable()
        {
            return _UntWork.contexto.Evento;
        }

        public IEnumerable<Evento> ListarMuitos(Func<Evento, bool> where)
        {
            return _UntWork.contexto.Evento.Where(where).ToList();
        }

        #endregion

    }
}