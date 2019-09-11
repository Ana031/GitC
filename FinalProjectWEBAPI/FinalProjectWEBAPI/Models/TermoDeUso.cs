using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class TermoDeUso : UserControls
    {
        [Key]
        public int IdTermo { get; set; }
        public int CodTermo { get; set; }
        public string Descricao { get; set; }
        public bool Vigente { get; set; }

    }
}