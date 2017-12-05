using AlimentoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentoAPI.Servico.Interface
{
    public interface IOrganizacoesFilantropicasServico
    {
        void Adicionar(OrganizacoesFilantropicas item);
        void Editar(OrganizacoesFilantropicas item);
        void Deletar(OrganizacoesFilantropicas item);
        void DeletarMuitos(Func<OrganizacoesFilantropicas, bool> where);
        OrganizacoesFilantropicas ObterPorID(int Id);
        OrganizacoesFilantropicas ObterPorDescricao(Func<OrganizacoesFilantropicas, bool> where);
        OrganizacoesFilantropicas ObterPrimeiro();
        OrganizacoesFilantropicas ObterPrimeiro(Func<OrganizacoesFilantropicas, bool> where);
        IEnumerable<OrganizacoesFilantropicas> ListarTudo();
        IQueryable<OrganizacoesFilantropicas> GetQueryable();
        IEnumerable<OrganizacoesFilantropicas> ListarMuitos(Func<OrganizacoesFilantropicas, bool> where);

    }
}
