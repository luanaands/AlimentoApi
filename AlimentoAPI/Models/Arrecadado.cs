using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models
{
    public class Arrecadado
    {

        public Arrecadado()
        {
            this.eventos = new HashSet<Evento>();
            this.doacoes = new HashSet<Doacao>();
        }

        public int id { get; set; }
        public virtual ICollection<Evento> eventos { get; set; }
        public virtual ICollection<Doacao> doacoes { get; set; }
    }
}