using AlimentoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentoAPI.Repositorio.Interface
{
    public interface IDoacaoRepositorio
    {
        void Adicionar(Doacao item);
        void Editar(Doacao item);
        void Deletar(Doacao item);
        void DeletarMuitos(Func<Doacao, bool> where);
        Doacao ObterPorID(int Id);
        Doacao ObterPorDescricao(Func<Doacao, bool> where);
        Doacao ObterPrimeiro();
        Doacao ObterPrimeiro(Func<Doacao, bool> where);
        IEnumerable<Doacao> ListarTudo();
        IQueryable<Doacao> GetQueryable();
        IEnumerable<Doacao> ListarMuitos(Func<Doacao, bool> where);

    }
}
