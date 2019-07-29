using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraInterestelar
{
    public class MostrandoCalculadoraInterestelar
    {
        public double CalculadoraAdicao(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        public double CalculadoraDivisao(double valor1, double valor2)
        {
            return valor1 / valor2;   //teste
        }
        public double CalculadoraMultiplicacao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        public double CalculadoraSubtracao(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public double CalculoDaAreaDeUmRetangulo(double altura1, double base2)
        {
            return base2 * altura1;
        }
        public double CalculoDeAreaDeUmTrianguloEquilatero(double altura1, double base2)
        {
            return ((altura1 * base2) / 2);
        }
        public double CalculoDeRaio(double x)
        {
            return (Math.Sqrt(x / Math.PI));
        }

    }
}
