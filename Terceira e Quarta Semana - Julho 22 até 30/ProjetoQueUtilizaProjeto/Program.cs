using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalculadora;

namespace ProjetoQueUtilizaProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var bbCalc = new Calculadora();

            Console.WriteLine(bbCalc.CalculadoraAdicao(5,5));

            Console.ReadKey();
        }
    }
}
