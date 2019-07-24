using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserindoERemovendo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 5];

            int IndiceBaseDeDados = 0;

            Console.WriteLine("Iniciando sistema de lista de nome e idade.");
            var escolhaIncial = ApresentaMenuInicial();

            while (true)
            {
                switch (escolhaIncial)
                {
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;
                    case "5":
                        {
                            return;
                        }
                }
                escolhaIncial = ApresentaMenuInicial();
            }
        }
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("MENU\n");
            Console.WriteLine(">> DIGITE O NÚMERO DA OPÇÃO DESEJADA <<\n");
            Console.WriteLine("1 - Inserir um novo registro de livro.");
            Console.WriteLine("2 - Remover um novo registro de livro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Mostrar registros inativos.");
            Console.WriteLine("5 - Sair do sistema.");

            return Console.ReadLine();
        }
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("|          Inserindo valores na lista          |");
            Console.WriteLine("|______________________________________________|");

            Console.WriteLine("Informe o livro");
            var nomeDoLivro = Console.ReadLine();

            Console.WriteLine("Informe o autor");
            var autor = Console.ReadLine();

            AumentaTamanhoDeLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (indiceBase++).ToString();
                baseDeDados[i, 1] = nomeDoLivro;
                baseDeDados[i, 2] = autor;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine(">> Aperte enter para voltar ao menu inicial <<");

            Console.ReadKey();
        }
        public static void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistrosNAtivos = "false")
        {
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("|Apresentação das informações dentro da base de dados|");
            Console.WriteLine("|____________________________________________________|");

            if (mostrarRegistrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema:");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != mostrarRegistrosNAtivos)
                    Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                        $" -Livro: {baseDeDados[i, 1]} " +
                        $"- Autor:  {baseDeDados[i, 2]}\n" +
                        $"- Data Alteração: {baseDeDados[i, 4]}\n");
            }

            Console.WriteLine("Resultado apresentado com sucesso!");
            Console.WriteLine(">> Aperte enter para voltar ao menu inicial <<");

            Console.ReadKey();
        }
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("________________________________________");
            Console.WriteLine("|Área de remoção do registro do sistema|");
            Console.WriteLine("|______________________________________|");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != "false")

                    Console.WriteLine($"ID:{baseDeDados[i, 0]}" +
                         $"- NomeDoLivro:{baseDeDados[i, 1]} " +
                        $"- Autor:{baseDeDados[i, 2]}\n");
            }

            Console.WriteLine("Informe o id do registro a ser removido");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 3] = "false";
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            Console.WriteLine("Operação finalizada.");
            Console.WriteLine(">> Para retornar ao menu inicial apertar enter <<");

            Console.ReadKey();

        }
        public static void AumentaTamanhoDeLista(ref string[,] ListaDeNome)
        {
            var limiteDaLista = true;

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }
            if (limiteDaLista)
            {
                var listaCopia = ListaDeNome;
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 5];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                    ListaDeNome[i, 2] = listaCopia[i, 2];
                    ListaDeNome[i, 3] = listaCopia[i, 3];
                    ListaDeNome[i, 4] = listaCopia[i, 4];
                }
                Console.WriteLine("Registros atualizados:");
            }
        }
    }
}
