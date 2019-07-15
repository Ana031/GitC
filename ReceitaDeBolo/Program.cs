using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDeBolo
{
    class Program
    {
        static void Main(string[] args)
        {
             
            MostrarSejaBemVindo();
            
            string[] baseReceita = new string[7];

                baseReceita[0] = "3 copos de trigo";
                baseReceita[1] = "2 copos de açúcar";
                baseReceita[2] = "1 copo de chocolate em pó";
                baseReceita[3] = "1 copo de óleo";
                baseReceita[4] = "3 ovos";
                baseReceita[5] = "1 copo de água quente";
                baseReceita[6] = "1 colher de sopa de fermento em pó";

            Console.WriteLine("Insira os seguintes ingredientes: -> APERTE ENTER ");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine(baseReceita[0]);
            Console.ReadKey();
            Console.WriteLine(baseReceita[1]);
            Console.ReadKey();
            Console.WriteLine(baseReceita[2]);
            Console.ReadKey();
            Console.WriteLine(baseReceita[3]);
            Console.ReadKey();
            Console.WriteLine(baseReceita[4]);
            Console.ReadKey();
            Console.WriteLine(baseReceita[5]);
            Console.ReadKey();
            Console.WriteLine(baseReceita[6]);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Misture tudo e coloque no forno durante 30 minutos em 250 graus.");
            Console.ReadKey();

        }

        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("                             _________________________________________________________");
            Console.WriteLine("                             |       HOJE VOCÊ FARA A MELHOR RECEITA DA SUA VIDA     |");
            Console.WriteLine("                             |_______________________________________________________|");
            Console.WriteLine("                             |        APROVEITE PORQUE DEPOIS VOCÊ PODERÁ COMER      |");
            Console.WriteLine("                             |_______________________________________________________|");
            Console.WriteLine("                             |                                                       |");
            Console.WriteLine("                             |            APERTE ENTER PARA PROSSEGUIR               |");
            Console.WriteLine("                             |_______________________________________________________|");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("    DAQUI EM DIANTE COMEÇAREMOS UM TUTORIAL DE COMO FAZER UM BOLO DE CHOCOLATE                    ");

            Console.WriteLine("                    (\\                                      ");
            Console.WriteLine("                      \\|                                    ");
            Console.WriteLine("                 __    \\/ ___,.-------..__        __        ");
            Console.WriteLine("                //\\ _,-'\\               `'--._ //\\        ");
            Console.WriteLine("               \\ ;'      \\                   `: //         ");
            Console.WriteLine("               `(          \\                   )'           ");
            Console.WriteLine("                :.          \\,----,         ,;              ");
            Console.WriteLine("                  `.`--.___   (    /  ___.--','              ");
            Console.WriteLine("                    `.     ``-----'-''     ,'                ");
            Console.WriteLine("                       -.               ,-                   ");
            Console.WriteLine("                          `-._______.-'                      ");
            Console.ReadKey();
            Console.Clear();
   
        }
    }
}
