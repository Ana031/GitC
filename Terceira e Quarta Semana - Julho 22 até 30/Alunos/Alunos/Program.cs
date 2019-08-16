using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    class Program
    {
        static string[,] listagem;
        static void Main(string[] args)
        {
            MostrarSejaBemVindo();

                string[,] listaDeNomes = new string[20, 3]
                {{"Ana","18","Feminino"},
                {"Luiz","17","Masculino"},
                {"Gabi","20","Feminino"},
                {"Gabriel","14","Masculino"},
                {"Luiza","24","Feminino"},
                {"Lucas","23","Masculino"},
                {"Milena","18","Feminino"},
                {"Marcelo","21","Masculino"},
                {"Giovana","29","Feminino"},
                {"Fernando","17","Masculino"},
                {"Fabi","30","Feminino"},
                {"Matheus","19","Masculino"},
                {"Julia","26","Feminino"},
                {"Gustavo","17","Masculino"},
                {"Eduarda","18","Feminino"},
                {"Willian","16","Masculino"},
                {"Gabreile","28","Feminino"},
                {"Felipe","27","Masculino"},
                {"Maju","31","Feminino"},
                {"Fernando","24","Masculino"},
                
                };

            for (int i = 0; i < listaDeNomes.GetLength(0); i++)

            {
                var Nome = listaDeNomes[i, 0];
                var idade = listaDeNomes[i, 1];
                var sexo = listaDeNomes[i, 2];

                Console.WriteLine($"{Nome} tem: {idade} e é do sexo {sexo}.");
            }

            Console.ReadKey();
        }
            public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("                             _________________________________________________________");
            Console.WriteLine("                             |                                                       |");
            Console.WriteLine("                             |                                                       |");
            Console.WriteLine("                             |                                                       |");
            Console.WriteLine("                             |                A SEGUIR >>>> LISTAGEM                 |");
            Console.WriteLine("                             |                                                       |");
            Console.WriteLine("                             |                                                       |");
            Console.WriteLine("                             |_______________________________________________________|");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
