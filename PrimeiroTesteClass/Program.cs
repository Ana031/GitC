using PrimeiroTesteClass.InformaçoesCompacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroTesteClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Compactando();
            teste.CarregarLista();

            Console.ReadKey();
        }

    }
}
