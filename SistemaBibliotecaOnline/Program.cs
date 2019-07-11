using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    AlocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
            }

            if (MenuPrincipal() == 1)
            {
                AlocarUmLivro();
            }

            Console.ReadKey();

        }
        /// <summary>
        /// Mostra informações iniciais do sistema 
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("  _________________________________________________________");
            Console.WriteLine("  |             Sistema de Alocação de Livros             |");
            Console.WriteLine("  |_______________________________________________________|");
            Console.WriteLine("  |        Desenvolvido pelas industrias EneEseAaaaa      |");
            Console.WriteLine("  |_______________________________________________________|\n");

        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu inicial com as opções de escolha
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro</returns> 
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine(" \r\n   MENU INICIAL");
            Console.WriteLine("   O que você deseja realizar?");
            Console.WriteLine("   Escolha uma opção\n");
            Console.WriteLine("   1 - Alocar um livro.");
            Console.WriteLine("   2 - Devolver um livro.");
            Console.WriteLine("   3 - Sair do sistema.");



            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema 
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno", "sim"},
                {"O grande","não"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro caso o livro estiveja livre para alocação</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {

                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro: {nomeLivro}" +
                        $" pode ser alocado? -> {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }
            return false;

        }
        /// <summary>
        /// Metodo para alterar a informação de alocaçaõ do livro
        /// </summary>
        /// <param name="nomeLivro">Nome do Livro</param>
        /// <param name="alocar">Valor booleano que define se o livro esta ou não disponivel</param>
        public static void AlocarLivros(string nomeLivro, bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    baseDeLivros[i, 1] = alocar ? "não" : "sim";
                }

            }
            Console.Clear();
            MostrarListaDeLivros();
            Console.WriteLine("Livro Alocado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o menu inicial do aplicativo do menu 1
        /// </summary>
        public static void AlocarUmLivro()
        {
            MostrarMenuInicialLivros("Alocar um Livro");

            var nomedolivro = Console.ReadLine();
            if (PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                MostrarListaDeLivros();
                Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");

                AlocarLivros(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metoda que mostra a lista de livros atualizada
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de Livros:");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel: {baseDeLivros[i, 1]}");
            }
        }
        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um Livro");

            MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            if (!PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                MostrarListaDeLivros();
                Console.WriteLine("Você deseja desalocar o livro? para sim(1) para não(0)");

                AlocarLivros(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialLivros(string operacao)
        {

            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"  MENU  -  {operacao}");
            Console.WriteLine("  Digite o nome do livro a ser alocado");
        }
            
    }

}

