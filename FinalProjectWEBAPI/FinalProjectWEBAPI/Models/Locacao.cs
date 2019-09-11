using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class Locacao : UserControls
    {
        [Key]
        public int IdLocacao { get; set; }
        public int CodLocacao { get; set; }
       // public virtual Usuario NomeUsuario { get; set; }

        public bool AceitaTermodeUso { get; set; }


        [ForeignKey("TipoVeiculoFK")]
        public TipoVeiculo Veiculo { get; set; }
        public int? TipoVeiculoFK { get; set; }


        [ForeignKey("MarcaFK")]
        public Marca Marca { get; set; }
        public int MarcaFK { get; set; }


        [ForeignKey("ModeloFK")]
        public Modelo Modelo { get; set;}
        public int ModeloFK { get; set; }


        [ForeignKey("CorFK")]
        public Cor Cor { get; set; }
        public int CorFK { get; set; }


        [CustomValidFields(Enums.ValidFields.ValidaPlaca)]
        public string Placa { get; set; }


        [ForeignKey("PeriodoFK")]
        public Periodo Periodo { get; set; }
        public int? PeriodoFK { get; set; }


        [ForeignKey("UsuarioFK")]
        public Usuario CodUsuario { get; set; }
        public int? UsuarioFK { get; set; }


        public string Status { get; set; }


       // [CustomValidFields(Enums.ValidFields.ValidaTermoDeUso)]
        [ForeignKey("TermoDeUsoFK")]
        public TermoDeUso TermoDeUso { get; set; }
        public int TermoDeUsoFK { get; set; } // fazer no PUT

    }
}

