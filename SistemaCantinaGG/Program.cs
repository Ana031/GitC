using SistemaCantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Cantina accountUser = new Cantina();

            while (accountUser.Saldo > 0.00)
            {
                MostrarMenu();

                var opcaoEscolhida = Console.ReadLine();
                var valor = 0.00;

                switch (opcaoEscolhida)

                {
                    case "1": { valor = 10; } break;
                    case "2": { valor = 5; } break;
                    case "3": { valor = 10; } break;
                }

                if (valor > 0 && accountUser.Retirada(valor))
                    Console.WriteLine("Agora voce pode comer seu lanchinho :)");
                else
                    Console.WriteLine("Seu pobre, voce nao tem dinheiro pra comer");

                Console.WriteLine($"Voce ainda tem {accountUser.Saldo.ToString("N2")}");

                Console.ReadKey();
            }
        }
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine(">> INFORME O NUMERO DO PRODUTO DESEJADO ANA <<\r\n");
            Console.WriteLine("1 - Omelete - $10");
            Console.WriteLine("2 - Pão com ovo - $5");
            Console.WriteLine("3 - Ovo cru - $10");
        }
    }
}
