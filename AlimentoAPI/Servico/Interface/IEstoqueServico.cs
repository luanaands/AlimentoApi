using AlimentoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentoAPI.Servico.Interface
{
    public interface IEstoqueServico
    {


        void Adicionar(Estoque item);
        void Editar(Estoque item);
        void Deletar(Estoque item);
        void DeletarMuitos(Func<Estoque, bool> where);
        Estoque ObterPorID(int Id);
        Estoque ObterPorDescricao(Func<Estoque, bool> where);
        Estoque ObterPrimeiro();
        Estoque ObterPrimeiro(Func<Estoque, bool> where);
        IEnumerable<Estoque> ListarTudo();
        IQueryable<Estoque> GetQueryable();
        IEnumerable<Estoque> ListarMuitos(Func<Estoque, bool> where);
    }
}
