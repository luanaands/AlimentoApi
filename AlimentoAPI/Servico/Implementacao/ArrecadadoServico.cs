using AlimentoAPI.Models;
using AlimentoAPI.Repositorio.Interface;
using AlimentoAPI.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Servico.Implementacao
{
    public class ArrecadadoServico : IArrecadadoServico
    {
        public IArrecadadoRepositorio ArrecadadoRepositorio { get; set; }

        #region IParametroServico Members

        void IArrecadadoServico.Adicionar(Arrecadado item)
        {
            ArrecadadoRepositorio.Adicionar(item);
        }

        void IArrecadadoServico.Editar(Arrecadado item)
        {
            ArrecadadoRepositorio.Editar(item);
        }

        void IArrecadadoServico.Deletar(Arrecadado item)
        {
            ArrecadadoRepositorio.Deletar(item);
        }

        void IArrecadadoServico.DeletarMuitos(Func<Arrecadado, bool> where)
        {
            ArrecadadoRepositorio.DeletarMuitos(where);
        }

        Arrecadado IArrecadadoServico.ObterPorID(int Id)
        {
            return ArrecadadoRepositorio.ObterPorID(Id);
        }

        Arrecadado IArrecadadoServico.ObterPorDescricao(Func<Arrecadado, bool> where)
        {
            return ArrecadadoRepositorio.ObterPorDescricao(where);
        }

        Arrecadado IArrecadadoServico.ObterPrimeiro()
        {
            return ArrecadadoRepositorio.ObterPrimeiro();
        }

        Arrecadado IArrecadadoServico.ObterPrimeiro(Func<Arrecadado, bool> where)
        {
            return ArrecadadoRepositorio.ObterPrimeiro(where);
        }

        IEnumerable<Arrecadado> IArrecadadoServico.ListarTudo()
        {
            return ArrecadadoRepositorio.ListarTudo();
        }

        IQueryable<Arrecadado> IArrecadadoServico.GetQueryable()
        {
            return ArrecadadoRepositorio.GetQueryable();
        }

        IEnumerable<Arrecadado> IArrecadadoServico.ListarMuitos(Func<Arrecadado, bool> where)
        {
            return ArrecadadoRepositorio.ListarMuitos(where);
        }

        #endregion

    }
}