using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Servico.Implementacao
{
    public class EventoServico : IEventoServico
    {
        public IEventoRepositorio EventoRepositorio { get; set; }

        #region IParametroServico Members

        void IEventoServico.Adicionar(Evento item)
        {
            EventoRepositorio.Adicionar(item);
        }

        void IEventoServico.Editar(Evento item)
        {
            EventoRepositorio.Editar(item);
        }

        void IEventoServico.Deletar(Evento item)
        {
            EventoRepositorio.Deletar(item);
        }

        void IEventoServico.DeletarMuitos(Func<Evento, bool> where)
        {
            EventoRepositorio.DeletarMuitos(where);
        }

        Evento IEventoServico.ObterPorID(int Id)
        {
            return EventoRepositorio.ObterPorID(Id);
        }

        Evento IEventoServico.ObterPorDescricao(Func<Evento, bool> where)
        {
            return EventoRepositorio.ObterPorDescricao(where);
        }

        Evento IEventoServico.ObterPrimeiro()
        {
            return EventoRepositorio.ObterPrimeiro();
        }

        Evento IEventoServico.ObterPrimeiro(Func<Evento, bool> where)
        {
            return EventoRepositorio.ObterPrimeiro(where);
        }

        IEnumerable<Evento> IEventoServico.ListarTudo()
        {
            return EventoRepositorio.ListarTudo();
        }

        IQueryable<Evento> IEventoServico.GetQueryable()
        {
            return EventoRepositorio.GetQueryable();
        }

        IEnumerable<Evento> IEventoServico.ListarMuitos(Func<Evento, bool> where)
        {
            return EventoRepositorio.ListarMuitos(where);
        }

        #endregion

    }
}