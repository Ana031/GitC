using FinalProjectWEBAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FinalProjectWEBAPI.Models
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
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaNomeAdm: return ValidaNomeAdm(value, validationContext.DisplayName);
                    case ValidFields.ValidaNomeUsuario: return ValidaNomeUsuario(value, validationContext.DisplayName);
                    case ValidFields.ValidaEmailAdm: return ValidaEmailAdm(value, validationContext.DisplayName);
                    case ValidFields.ValidaEmailUsuario: return ValidaEmailUsuario(value, validationContext.DisplayName);
                    case ValidFields.ValidaPlaca: return ValidaPlaca(value, validationContext);
                    case ValidFields.ValidaValor:
                    case ValidFields.ValidaQtdDeVagas:
                    case ValidFields.ValidaTermoDeUso: //return ValidaTermoDeUso(value, validationContext.DisplayName);
                    case ValidFields.FilaDeEspera:
                    default:
                        break;
                }

            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatorio");
        }

        private ValidationResult ValidaPlaca(object value, ValidationContext validationContext)
        {
            #region Valida Campo Moto e Carro > Porem não funciona
            //    Locacao tipoVeiculo = (Locacao)validationContext.ObjectInstance;

            //    if (tipoVeiculo.TipoVeiculoFK > 1 && value == null)
            //        return ValidationResult.Success;
            //    if (tipoVeiculo.TipoVeiculoFK > 1 && value != null)
            //        return new ValidationResult("Este campo d veículo não permite o cadastro de placa");
            //    if (tipoVeiculo.TipoVeiculoFK == 1 && value != null)
            //    {
            //        if (Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$") || Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$"))
            //        {
            //            if (dB.Locacaos.Any(x => x.Placa == value.ToString()))
            //                return new ValidationResult($"A placa {value} já está cadastrada no sistema");
            //            return ValidationResult.Success;
            //        }
            //        return new ValidationResult($"Formato inválido no campo {validationContext.DisplayName}");
            //    }
            //    if (tipoVeiculo.TipoVeiculoFK == 2 && value != null)
            //    {
            //        if (Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$"))
            //        {
            //            if (dB.Locacaos.Any(x => x.Placa == value.ToString()))
            //                return ValidationResult.Success;
            //            return new ValidationResult($"A placa {value} já está cadastrada no sistema");
            //        }
            //        return new ValidationResult($"A placa {value.ToString()} nã está no formato aceitável");
            //    }
            //    return new ValidationResult($"O campo {validationContext.DisplayName} deve ser informado");
            //}
            #endregion

            // value = value.ToString().Replace("-", "");

            Locacao tipoVeiculo = (Locacao)validationContext.ObjectInstance;

            if (tipoVeiculo.TipoVeiculoFK > 2 && value == null)
                return ValidationResult.Success;
                if (tipoVeiculo.TipoVeiculoFK > 2 && value != null)
                return new ValidationResult("Este campo não permite o cadastro de placa");

            if (tipoVeiculo.TipoVeiculoFK <= 2 && value != null)
            {

                bool placaBr = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$");
                bool placaMs = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");
                bool placaMt = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$");

                if (placaBr || placaMs || placaMt)
                {
                    Locacao locacao = dB.Locacaos.FirstOrDefault(x => x.Placa == value.ToString());

                    if (locacao == null)
                        return ValidationResult.Success;
                    else
                        return new ValidationResult($"O campo {validationContext.DisplayName} já está cadastrado");
                }
                return new ValidationResult($"A placa {validationContext.DisplayName} não está no formato aceitável");
            }
            return new ValidationResult($"Informe um valor para o campo {validationContext.DisplayName} ");


        }

        private ValidationResult ValidaEmailAdm(object value, string displayFields)
        {
            bool emailAdm = Regex.IsMatch(value.ToString(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (emailAdm)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayFields} é inválido");
        }

        private ValidationResult ValidaEmailUsuario(object value, string displayFields)
        {
            bool emailUsuario = Regex.IsMatch(value.ToString(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (emailUsuario)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayFields} é inválido");
        }

        private ValidationResult ValidaNomeUsuario(object value, string displayField)
        {
            bool nomeUsuario = Regex.IsMatch(value.ToString(), "^(([a-zA-Z ]|[é])*)$");

            if (nomeUsuario)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} não está no formato aceitável!");
        }

        private ValidationResult ValidaNomeAdm(object value, string displayField)
        {
            bool nomeAdm = Regex.IsMatch(value.ToString(), "^(([a-zA-Z ]|[é])*)$");

            if (nomeAdm)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} não está no formato aceitável!");
        }

        //private ValidationResult FilaDeEspera(object value, string displayField)
        //{
           
        //}
    }
}