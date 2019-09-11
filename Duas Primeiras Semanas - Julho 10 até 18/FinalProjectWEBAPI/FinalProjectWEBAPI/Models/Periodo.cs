using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class Periodo : UserControls
    {
        [Key]
        public int IdPeriodo { get; set; }
        public int CodPeriodo { get; set; }
        public int QtdDeVagas { get; set; }

        [JsonConverter(typeof(DateConverter))]
        public DateTime DatInicial { get; set; }


        [JsonConverter(typeof(DateConverter))]
        public DateTime DataFinal { get; set; }


        [ForeignKey("TipoVeiculoFK")]
        public TipoVeiculo Veiculo {get; set;}
        public int? TipoVeiculoFK { get; set; }
    }
}

