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
            //Criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 3];
            //Indicador do registro realizado em nosso sistema
            int IndiceBaseDeDados = 0;
            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de nome e idade.");
            //Criamos a variavel fora para não ser criada novamente
            var escolhaIncial = ApresentaMenuInicial();
            //Loop infinito
            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch (escolhaIncial)
                {
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    case "3": {  MostrarInformacoes(baseDeDados); } break;
                    case "4": {                  
                            //Return dentro do nosso caso de escolha ele sai do nosso metodo principal ou
                            //metodo que estamos dentro do contexto
                            return;
                        }
                }
                //Alimento a escolha novamente
                escolhaIncial = ApresentaMenuInicial();
            }
        }

        /// <summary>
                /// Apresenta as informações do menu inicial
                /// </summary>
                /// <returns>Retorna o menu escolhido</returns>
        public static string ApresentaMenuInicial()
                {
            Console.Clear();
                    Console.WriteLine("Menu");
                    Console.WriteLine("1 - Inserir um novo registro.");
                    Console.WriteLine("2 - Remover um novo registro.");
                    Console.WriteLine("3 - Listar informações.");
                    Console.WriteLine("4 - Sair do sistema.");

                    Console.WriteLine("Digite o número da opção desejada");
                    //Retorna diretamente o menu escolhido
                    return Console.ReadLine();
                }
        
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">base de dados como ref para alterar para todos os metados</param>
        /// <param name="indiceBase">indice da nossa base como red para alterar para todos os metodos</param>
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("----------Inserindo valores na lista-----------");

            Console.WriteLine("Informe o nome");
            //Pegamos a informação digitada pelo usuário, aqui neste
            var nome = Console.ReadLine();
           

            Console.WriteLine("Informe a idade");
            //Aqui pegamos a idade da pessoa digitada pelo usuario do sistema
            var idade = Console.ReadLine();
            AumentaTamanhoDeLista(ref baseDeDados);
            //iniciamos o laço de repetição para varrer nossa base de dados
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;
                //Identificamos de maneira unica nosso registro"("e")" garante que ele incremente primeiro
                //antes de fazer a conversão para string
                baseDeDados[i, 0] = (indiceBase++).ToString();
                //Carrega na segunda coluna o valor do nome
                baseDeDados[i, 1] = nome;
                //Carrega na terceira coluna o valor do nome
                baseDeDados[i, 2] = idade;
                //Finalizamos aqui para apenas inserir um registro por vez
                break;
            }
            //Informamos para o usuario que finalizou p registro e agora o mesmo irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados"base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para a leitura e mostra pro usuario</param>
        public static void MostrarInformacoes(string[,] baseDeDados)
        {
            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                    $" -Nome:{baseDeDados[i, 1]} " +
                    $"- Idade: {baseDeDados[i, 2]}");

            Console.WriteLine("Resultado apresentado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial apertar qualquer tecla");
            Console.ReadKey();
            
        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeDados"></param>
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remoção do registro do sistema");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID:{baseDeDados[i, 0]}" +
                     $"- Nome:{baseDeDados[i, 1]} " +
                    $"- Idade:{baseDeDados[i, 2]}");
            Console.WriteLine("Informe o id do registro a ser removido");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;
                }
            }
            Console.WriteLine("Operação finalizada.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }
        public static void AumentaTamanhoDeLista(ref string[,] ListaDeNome)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;

            //Laço que virifica se existe registro disponivel
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível ele seta nossa variavel "limiteDaLista" para false
                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }
            //Caso nao tenha mais registro nossa variavel ficou como true entao indica que precisamos aumentar nossa lista
            if (limiteDaLista)
            {
                //Criamos um copia da nossa lista para nao perder os valores
                var listaCopia = ListaDeNome;
                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços 
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];
                //Agora copiamos os registros da nossa lista antiga e passamos para nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a a informaçaõ do identificador unico
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    //Copiamos a informacao do nosso nome
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                    ListaDeNome[i, 2] = listaCopia[i, 2];
                }
                //Indicamos que nesse ponto a lista foi atualizada em seu tamanho
                Console.WriteLine("O tamanho da lista foi atualizado:");
            }

        }
    }
}
