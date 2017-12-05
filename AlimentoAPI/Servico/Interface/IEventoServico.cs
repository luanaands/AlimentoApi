using AlimentoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentoAPI.Servico.Interface
{
     public interface IEventoServico
    {
        void Adicionar(Evento item);
        void Editar(Evento item);
        void Deletar(Evento item);
        void DeletarMuitos(Func<Evento, bool> where);
        Evento ObterPorID(int Id);
        Evento ObterPorDescricao(Func<Evento, bool> where);
        Evento ObterPrimeiro();
        Evento ObterPrimeiro(Func<Evento, bool> where);
        IEnumerable<Evento> ListarTudo();
        IQueryable<Evento> GetQueryable();
        IEnumerable<Evento> ListarMuitos(Func<Evento, bool> where);


    }
}
