using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class Modelo : UserControls
    {
        [Key]
        public int IdModelo { get; set; }
        public int CodModelo { get; set; }
        public string Descricao { get; set; }

        [ForeignKey("MarcaFK")]
        public Marca Marca { get; set; }
        public int? MarcaFK { get; set; }
    }
}

