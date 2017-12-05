using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlimentoAPI.Models
{

    public partial class Menu
    {

        public List<Menu> listaMenu = new List<Menu>();
        public Menu()
        { }

        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [StringLength(150)]
        [Display(Name = "Módulo")]
        public string modulo { get; set; }

        [StringLength(150)]
        [Display(Name = "Ação")]
        public string acao { get; set; }

    }
}
