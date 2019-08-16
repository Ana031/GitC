using ListarMeusCarros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarMeusCaros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> minhaLista = new List<Carro>();

            for (int i = 0; i < 2; i++)
            {
                minhaLista.Add(new Carro()
                {
                    Modelo = Console.ReadLine(),
                    Ano = int.Parse(Console.ReadLine()),
                    Placa = Console.ReadLine(),
                    Cv = int.Parse(Console.ReadLine())

                });
            }
            foreach (Carro item in minhaLista)
            {
                Console.WriteLine($"Modelo: {item.Modelo} Ano: {item.Ano} " +
                    $"Placa: {item.Placa} Cv: {item.Cv}");
            }
            Console.ReadKey();
        }
        public static string RetornarValores(string Modelo)
        {
            Console.WriteLine($"Informe o Modelo: {Modelo}");
            return Console.ReadLine();
        }
     }
}
