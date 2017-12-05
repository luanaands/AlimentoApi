using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models
{
    public class OrganizacoesFilantropicas
    {
        public OrganizacoesFilantropicas() {

            this.doacoes= new HashSet<Doacao>();
        }

        public int id { get; set; }

        public int quantidadePessoas { get; set; }

        public string nome { get; set; }

        public string nomeRepresentante { get; set; }

        public string cnpj { get; set; }

        public string contato { get; set; }

        public string email { get; set; }
        
        public virtual ICollection<Doacao> doacoes { get; set; }

    }
}