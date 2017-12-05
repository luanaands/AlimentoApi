using AlimentoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentoAPI.Repositorio.Interface
{
    public interface IArrecadadoRepositorio
    {
        void Adicionar(Arrecadado item);
        void Editar(Arrecadado item);
        void Deletar(Arrecadado item);
        void DeletarMuitos(Func<Arrecadado, bool> where);
        Arrecadado ObterPorID(int Id);
        Arrecadado ObterPorDescricao(Func<Arrecadado, bool> where);
        Arrecadado ObterPrimeiro();
        Arrecadado ObterPrimeiro(Func<Arrecadado, bool> where);
        IEnumerable<Arrecadado> ListarTudo();
        IQueryable<Arrecadado> GetQueryable();
        IEnumerable<Arrecadado> ListarMuitos(Func<Arrecadado, bool> where);
    }
}
