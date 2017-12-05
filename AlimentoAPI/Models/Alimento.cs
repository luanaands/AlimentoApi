using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models
{
    public class Alimento
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string gramas { get; set; }

        public DateTime validade { get; set; }

        public string tipo { get; set; }

        public int idEstoque { get; set; } 

        public virtual Estoque estoque { get; set; }

    }
}