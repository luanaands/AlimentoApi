using AlimentoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentoAPI.Repositorio.Interface
{
   public  interface IInstituicaoRepositorio
    {
        void Adicionar(Instituicao item);
        void Editar(Instituicao item);
        void Deletar(Instituicao item);
        void DeletarMuitos(Func<Instituicao, bool> where);
        Instituicao ObterPorID(int Id);
        Instituicao ObterPorDescricao(Func<Instituicao, bool> where);
        Instituicao ObterPrimeiro();
        Instituicao ObterPrimeiro(Func<Instituicao, bool> where);
        IEnumerable<Instituicao> ListarTudo();
        IQueryable<Instituicao> GetQueryable();
        IEnumerable<Instituicao> ListarMuitos(Func<Instituicao, bool> where);

    }
}
