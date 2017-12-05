using AlimentoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentoAPI.Servico.Interface
{
    public interface IAlimentoServico
    {
    
        void Adicionar(Alimento item);
        void Editar(Alimento item);
        void Deletar(Alimento item);
        void DeletarMuitos(Func<Alimento, bool> where);
        Alimento ObterPorID(int Id);
        Alimento ObterPorDescricao(Func<Alimento, bool> where);
        Alimento ObterPrimeiro();
        Alimento ObterPrimeiro(Func<Alimento, bool> where);
        IEnumerable<Alimento> ListarTudo();
        IQueryable<Alimento> GetQueryable();
        IEnumerable<Alimento> ListarMuitos(Func<Alimento, bool> where);
    }
}
