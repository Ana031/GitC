using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject._00.Models
{
    public class Cliente : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EstadoCivil { get; set; }
        public int RG { get; set; }

        [RegularExpression(pattern: "^([0-9]){3}\\.([0-9]){3}\\.([0-9]){3}-([0-9]){2}$", ErrorMessage = "CPF inválido.")]
        public string CPFCNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        [RegularExpression(pattern: @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
    }
}