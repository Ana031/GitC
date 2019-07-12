using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBebidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStringContent = new string[2];

            for (int i = 0; i < arrayStringContent.Length; i++)
            {
                Console.WriteLine("Informe seu nome e idade:");
                var nome = Console.ReadLine();
                
                
                int.TryParse(Console.ReadLine(), out int idade);
                Console.Clear();

                if (idade > 18)
                {

                    Console.WriteLine("Liberado");
                    
                }
                else
                {
                    Console.WriteLine("Proibido");
                    
                }
                
                Console.ReadKey();
            }

        }
           
            
    }
}
