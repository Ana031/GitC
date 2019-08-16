using MinhaPrimeiraClasseTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraClasseTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 indicador <T> o tipo  da minha lista com isso temos uma
            //lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();
            //Adiciona na minha lista um pão de queijo
            minhaLista.Add(new Lanche()
            {
                Nome = "Pão de Queijo",
                Quantidade = 9,
                Valor = 1.85
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinha de Soya",
                Quantidade = 2,
                Valor = 7.50
            });
            //Aqui ando pela mnha lista para poder apresentar em tela os valores 
            //itm in significa que ele já é um indice da minha lista bonitinho
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.WriteLine("Removendo Item");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 2)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }

            //minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2));  >>expressão lambida

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.ReadKey();
        }
    }
}
