using FinalProject._00.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FinalProject._00.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDb dB = new ContextDb();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value  != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaNome:
                    case ValidFields.ValidaEstadoCivil:  
                    case ValidFields.ValidaRG:           
                    case ValidFields.ValidaCPFCNPJ:      return ValidaCPFCNPJ(value, validationContext.DisplayName);
                    case ValidFields.ValidaNomeFantasia: 
                    case ValidFields.ValidaCep:          
                    case ValidFields.ValidaEnderaco:     
                    case ValidFields.ValidaCidade:       
                    case ValidFields.ValidaEstado:       
                    case ValidFields.ValidaTelefone:     
                    case ValidFields.ValidaCelular:      
                    case ValidFields.ValidaEmail:        
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }

        private ValidationResult ValidaCPFCNPJ(object value, string displayFields)
        {
            Cliente user = dB.clientes.FirstOrDefault(x => x.CPFCNPJ == value.ToString());
            bool result = Regex.IsMatch(value.ToString(), "^([0-9]){3}\\.([0-9]){3}\\.([0-9]){3}-([0-9]){2}$");

            if (user == null)
                return ValidationResult.Success;
            else
                return new ValidationResult($"Este cmapo {displayFields} já está cadastrado");
        }

    }
}