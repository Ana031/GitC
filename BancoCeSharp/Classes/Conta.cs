using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta
    {
        double saldo = 0;
        //Propriedade que contem o valor do saldo
        public double Saldo { get { return saldo; } }


        public Conta()
        {
            //Bonus de mil reais para iniciar operar daytrade
            saldo = 1000;
        }
        /// <summary>
        /// Metodo para sacar de acorda com o saldo disponivel
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                //Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            //Retorna false em caso de não conter saldo dispovibel
             return false;
        }
        /// <summary>
        /// Metodo para mostrar o saldo em conta disponivel
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
