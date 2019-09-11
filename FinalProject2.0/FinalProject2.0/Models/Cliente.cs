using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject2._0.Models
{
    public class Cliente : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EstadoCivil { get; set; }
        public int RG { get; set; }
        public int CPF_CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }

    }
}