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
            Carrinho();

            var opcaoMenu = MenuPrincipal();

                while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    AlocarCarros();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                    Environment.Exit(0);

                opcaoMenu = MenuPrincipal();
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

            

        }
        public static void Carrinho()
        {
            MostrarSejaBemVindo(); 
            Console.WriteLine("                    __________________            ");
            Console.WriteLine("                   /        |         |           ");
            Console.WriteLine("         _________/ ________|_______  |____       ");
            Console.WriteLine("        |                                  |      ");
            Console.WriteLine("        |____      ______________      ____|      ");
            Console.WriteLine("             |____/              |____/           ");
            Console.ReadKey();
            Console.Clear();
        //
        //   MostrarSejaBemVindo();
        //   Console.WriteLine("                __________________            ");
        //   Console.WriteLine("               /        |         |           ");
        //   Console.WriteLine("     _________/ ________|_______  |____       ");
        //   Console.WriteLine("    |                                  |      ");
        //   Console.WriteLine("    |____      ______________      ____|      ");
        //   Console.WriteLine("         |____/              |____/           ");
        //   Console.ReadKey();
        //   Console.Clear();
        //
        //   MostrarSejaBemVindo();
        //   Console.WriteLine("            __________________            ");
        //   Console.WriteLine("           /        |         |           ");
        //   Console.WriteLine(" _________/ ________|_______  |____       ");
        //   Console.WriteLine("|                                  |      ");
        //   Console.WriteLine("|____      ______________      ____|      ");
        //   Console.WriteLine("     |____/              |____/           ");
        //   Console.ReadKey();
        //   Console.Clear();
        //

        }
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine(" \r\n   MENU INICIAL");
            Console.WriteLine("   Qual operação você deseja realizar?");
            Console.WriteLine("   Escolha uma opção\n");
            Console.WriteLine("   1 - Alocar carro.");
            Console.WriteLine("   2 - Desalocar carro.");
            Console.WriteLine("   3 - Sair do sistema.");


            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        public static void MostrarMenuInicialCarros(string opcao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"  MENU  -  {opcao} ");
            Console.WriteLine("  Digite o nome do carro\n");

        }
        public static bool? PesquisaCarroParaAlocacao(ref string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {

                if (CompararNomes(nomeCarro, baseDeCarros[i, 0]))
                {
                    Console.WriteLine($"O carro: {nomeCarro}" +
                        $" pode ser alocado? -> {baseDeCarros[i, 2]}");
                    
                    return baseDeCarros[i, 2] == "sim";
                
                }   
            }

            Console.WriteLine("Nenhum livro encontrado. Deseja realizar a busca novamente?");
            Console.WriteLine("Digite o númeri da opção desejada: Sim(1) Não(0)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)                                                            //Pode ser usado para senhas, geralndo um loop e não deixando sair enquanto a senha estiver errada
            {                                                                          //Pode ser usado para senhas, geralndo um loop e não deixando sair enquanto a senha estiver errada
                                                                                       //Pode ser usado para senhas, geralndo um loop e não deixando sair enquanto a senha estiver errada
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");         //Pode ser usado para senhas, geralndo um loop e não deixando sair enquanto a senha estiver errada
                nomeCarro = Console.ReadLine();                                        //Pode ser usado para senhas, geralndo um loop e não deixando sair enquanto a senha estiver errada
                                                                                       //Pode ser usado para senhas, geralndo um loop e não deixando sair enquanto a senha estiver errada
                return PesquisaCarroParaAlocacao(ref nomeCarro);                       //Pode ser usado para senhas, geralndo um loop e não deixando sair enquanto a senha estiver errada

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
        public static void AtualizarUmCarro(string nomeCarro, bool alocar)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (CompararNomes(nomeCarro, baseDeCarros[i, 0]))
                {
                    baseDeCarros[i, 2] = alocar ? "não" : "sim";
                }
                
            }
            Console.Clear();
            MostrarListaDeCarros();
            Console.WriteLine("Carro Alocado com sucesso!\n");
        }
        public static void AlocarCarros()
        {
            MostrarMenuInicialCarros("Alocar um Carro");

            var nomedocarro = Console.ReadLine();

            var resultadoPesquisa = PesquisaCarroParaAlocacao(ref nomedocarro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarListaDeCarros();
                Console.WriteLine("Você deseja alocar o carro? para sim(1) para não(0)");

                AtualizarUmCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum carro encontrado em nossa base de dados do sistema.");
            }
        }
        public static void MostrarListaDeCarros()
        {
            Console.WriteLine("Listagem de Carros:");

            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeCarros[i, 0]} Ano: {baseDeCarros[i, 1]} Disponivel: {baseDeCarros[i, 2]}");
            }
        }
        public static void DesalocarUmCarro()
        {
            MostrarMenuInicialCarros("Desalocar um Carro");

            MostrarListaDeCarros();

            var nomedocarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaCarroParaAlocacao(ref nomedocarro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarListaDeCarros();
                Console.WriteLine("Você deseja desalocar o carro? para sim(1) para não(0)");

                AtualizarUmCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum livro enconrado em nossa base de dados do sistema .");


            }
        }
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }

    }
}
