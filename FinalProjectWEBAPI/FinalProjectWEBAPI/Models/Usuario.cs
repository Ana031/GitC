using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int IdUsuario  { get; set; }
        public int CodUsuario { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaNomeUsuario)]
        public string NomeUsuario { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaEmailUsuario)]
        public string EmailUsuario { get; set; }
        public bool PCD { get; set; } = false;
        public bool Idoso { get; set; } = false;
        public bool PeriodoNoturno { get; set; } = false;
        public bool ForaDaCidade { get; set; } = false;
        public bool Carona { get; set; } = false;

        //[ForeignKey("LocacoesFK")]
        //public Locacao Locacao { get; set; }
        //public int LocacoesFK { get; set; }

    }
}