using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class Marca : UserControls
    { 
        [Key]
        public int IdMarca { get; set; }
        public int CodMarcas { get; set; }
        public string Descricao { get; set; }


        [ForeignKey("TipoVeiculoFK")]
        public TipoVeiculo Veiculo { get; set; }
        public int? TipoVeiculoFK { get; set; }

    }
}

