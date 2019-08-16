using LanchoneteInterestelar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteInterestelar
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializei minha lista
            List<Lanche> minhaLista = new List<Lanche>();

            for (int i = 0; i < 5; i++)
            {
                minhaLista.Add(new Lanche()
                {
                    Nome = Console.ReadLine(),
                    Quantidade = int.Parse(Console.ReadLine()),
                    Valor = double.Parse(Console.ReadLine())
                });
            }

            //Aqui ando pela mnha lista para poder apresentar em tela os valores 
            //itm in significa que ele já é um indice da minha lista bonitinho
            foreach (Lanche item in minhaLista)
            {
                Console.WriteLine($"Nome: {item.Nome} Quantidade: {item.Quantidade} Valor: {item.Valor}");
            }
            Console.ReadKey();

        }
           public static string RetornaValores(string nome)
            {
                Console.WriteLine($"Informe o valor para o campo: {nome}");
                return Console.ReadLine();
            }
    }
}
