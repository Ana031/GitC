using CalculadoraShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraShow;
namespace AcessandoDLLDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            var bbCalc = new Class1();

            var somar = new Class1().Somar(5,5);

            var diminuir = new Class1().Diminuir(5,5);

            var dividir = new Class1().Dividir(5, 5);

            var multiplica = new Class1().Multiplicar(5, 5);

            var equilatero = new Class1().areadoequilatero(5, 5);

            var retangulo = new Class1().areadoRetangulo(5, 5);

            var raio = new Class1().CalcularRaio(5);


            Console.WriteLine(somar);
            Console.WriteLine(diminuir);
            Console.WriteLine(dividir);
            Console.WriteLine(multiplica);
            Console.WriteLine(equilatero);
            Console.WriteLine(retangulo);
            Console.WriteLine(raio);

            Console.ReadKey();
        }
    }
}
