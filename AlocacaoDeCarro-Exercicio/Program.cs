using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoDeCarro_Exercicio
{
    class Program
    {
        static string[,] baseDeCarros;                                                                                                   
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarSejaBemVindo();

            if (MenuInicial() == 1)
            {
                MostrarMenuAlocacao();
            }

            Console.ReadKey();
        }
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("  _________________________________________________________");
            Console.WriteLine("  |         Sistema de Alocação de Carros de Luxo         |");
            Console.WriteLine("  |_______________________________________________________|");
            Console.WriteLine("  |             Desenvolvido pela mestre Ana              |");
            Console.WriteLine("  |_______________________________________________________|\n");

            Console.WriteLine("            ____________                  ");
            Console.WriteLine("           /            \                 ");
            Console.WriteLine("          /              \                ");
            Console.WriteLine("   ______/                \______         ");
            Console.WriteLine("  /                              \        ");
            Console.WriteLine(" /___      _______________     ___\       ");
            Console.WriteLine("     \___/                \___/           ");
            Console.ReadKey();
            
            


        }
        public static int MenuInicial()
        {
            Console.WriteLine(" \r\n   MENU INICIAL");
            Console.WriteLine("   Deseja alocar um carro?");
            Console.WriteLine("   Escolha uma opção\n");
            Console.WriteLine("   1 - Sim.");
            Console.WriteLine("   2 - Sair do sistema.");



            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        public static void MostrarMenuAlocacao()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("  MENU  -  ALOCAÇÃO DE CARROS DE LUXO");
            Console.WriteLine("  Digite o nome do carro que você deseja alocar");


            var nomedocarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o carro? para sim(1) para não(0)");

                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarCarro(nomedocarro);
                    Console.Clear();
                    Console.WriteLine("AGORA VOCÊ PODE VIAJAR NA SUA NAVE");
                }


                else
                    Console.Clear();

            }
                Console.WriteLine("Listagem de Carros:");

                for (int i = 0; i < baseDeCarros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeCarros[i, 0]} Ano: {baseDeCarros[i, 1]} Disponivel: {baseDeCarros[i, 2]} ");
                }

                

            
        }
        public static bool PesquisaCarroParaAlocacao(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {

                if (nomeCarro == baseDeCarros[i, 0])
                {
                    Console.WriteLine($"O carro: {nomeCarro}" +
                        $" pode ser alocado? -> {baseDeCarros[i, 2]}");
                    

                    return baseDeCarros[i, 2] == "sim";
                    

                }
               
            }
            return false;

        }
        public static void CarregaBaseDeDados()
        {
            baseDeCarros = new string[2, 3]
            {
                {"Jaguar", "2008", "sim"},
                {"BMW","2011", "não"}
            };
        }
        public static void AlocarCarro(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                    baseDeCarros[i, 2] = "não";                 
            }
        }

    }
}
