using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models
{
    public class Doacao
    {

        public int id { get; set; }

        public int idOrganizacaoFila { get; set; }

        public int idArrecadado { get; set; }

        public virtual Arrecadado arrecadado { get; set; }

        public virtual OrganizacoesFilantropicas organizacao { get; set; }



    }
}