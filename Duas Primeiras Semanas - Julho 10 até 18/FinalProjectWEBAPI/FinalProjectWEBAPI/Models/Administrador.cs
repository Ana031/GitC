using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class Administrador : UserControls
    {
        [Key]
        public int IdAdm { get; set; }
        public int CodAdm { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaNomeAdm)]
        public string NomeAdm { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaEmailAdm)]
        public string EmailAdm { get; set; }
    }
}