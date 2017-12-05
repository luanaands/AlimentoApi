using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models
{
    public class Evento
    {

        public Evento() { }

        //Primary key
        public int id { get; set; }
        //foreign key 
        //one for one
        public int idInstituicao { get; set; }
        public int idArrecadado { get; set; }
        //
        public DateTime inicio { get;  set; }

        public DateTime fim { get; set; }

        public string nome { get; set; }

        public string publico { get; set; }

        public virtual Estoque estoque { get; set; }

        public virtual Instituicao instituicao { get; set; }

        public virtual Arrecadado arrecadado { get; set; }
    }
}