using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Calculadora
    {
        public int CalculadoraAdicao(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int CalculadoraDivisao(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        public int CalculadoraMultiplicacao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public int CalculadoraSubtracao(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
    }
}
