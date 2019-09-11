using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class TipoVeiculo : UserControls
    {
        [Key]
        public int IdVeiculo { get; set; }
        public int CodVeiculo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; } = 00;

    }
}