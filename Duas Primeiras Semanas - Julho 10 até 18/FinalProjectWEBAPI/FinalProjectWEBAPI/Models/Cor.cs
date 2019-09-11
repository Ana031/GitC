using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class Cor : UserControls
    {
        [Key]
        public int IdCor { get; set; }
        public int CodCor { get; set; }
        public string Descricao { get; set; }
    }
}