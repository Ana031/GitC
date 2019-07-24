using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddListaDeCarros
    //Deveremos cadastrar os valores nelas
    //O valor de identificação não pode ser informado pelo usuario
    //A lista deve ser chamada 2 vezes para ser inserida
    //Dentro destas chamadas não podemos sobrescrever as informações anteriores
    //Extra: A lista aumenta de acordo com as informações
    //Super Extra: apagar um registro da lista e inserir no espaço liberado novamente
{
    class Program
    {
        static void Main(string[] args)
        {
   
            string[,] listaDeCarros = new string[10, 3];
            
            int IdParaLista = 0;
            
            InsereRegistro(ref listaDeCarros, ref IdParaLista);

            Console.ReadKey();
            
            InsereRegistro(ref listaDeCarros, ref IdParaLista);

            Console.WriteLine("\r\nDeseja remover algum dado?");
            
            int.TryParse(Console.ReadLine(), out int opcao);
            if (opcao == 1) 
            {
                Excluir(ref listaDeCarros);
            }

            Console.ReadKey();
        }

        public static void InsereRegistro(ref string[,] listaDeCarros, ref int IdParaLista)
        {
            
            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
            {
   
                if (listaDeCarros[i, 0] != null)
                    continue;

                Console.Clear();
                Console.WriteLine("\r\nInforme o nome do carro desejado:");
                var nome = Console.ReadLine();
                Console.WriteLine("\r\nInforme o ano do carro:");
                var ano = Console.ReadLine();

                listaDeCarros[i, 0] = (IdParaLista++).ToString();
                
                listaDeCarros[i, 1] = nome;
                listaDeCarros[i, 2] = ano;


                Console.WriteLine("Deseja inserir um novo registro? Sim(1) Não(0)");
                
                var continuar = Console.ReadKey().KeyChar.ToString();
                
                if (continuar == "0")
                    break; 
 
                AumentaTamanhoDeLista(ref listaDeCarros);

            }

           
            Console.WriteLine("Registro adicionado com sucesso! Segue lista de informações adicionais:");


            listar(listaDeCarros);
        }
        public static void AumentaTamanhoDeLista(ref string[,] listaDeCarros)
        {
            var limiteDaLista = true;

            
            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
            {
                
                if (listaDeCarros[i, 0] == null)
                    limiteDaLista = false;
            }
            
            if (limiteDaLista)
            {
                
                var listaCopia = listaDeCarros;
                 
                listaDeCarros = new string[listaDeCarros.GetLength(0) + 5, 3];
               
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    
                    listaDeCarros[i, 0] = listaCopia[i, 0];
                   
                    listaDeCarros[i, 1] = listaCopia[i, 1];

                    listaDeCarros[i, 2] = listaCopia[i, 2];
                }
               
                Console.WriteLine("O tamanho da lista foi atualizado:");
            }
 
            
        }

		public static void Excluir(ref string [,] listaDeCarros)

        {
            Console.WriteLine("Inserir Numero do ID a ser removido");
            var remover = Console.ReadLine();

            for (int i = 0; i < listaDeCarros.GetLength(0); i++)

            {
                if (listaDeCarros[i, 0] == remover)
                {
                    listaDeCarros[i, 1] = null;
                    listaDeCarros[i, 2] = null;
                }                
            }
            listar(listaDeCarros);
        }

        public static void listar(string[,] listaDeCarros)
        {
            for (int i = 0; i < listaDeCarros.GetLength(0); i++)

                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1} - ano: {2}", listaDeCarros[i, 0], listaDeCarros[i, 1], listaDeCarros[i, 2]));
        }
    }

}
    

