using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];

            //Aqui com estamos usando apenas uma referencia da nossa lista colocamos ref ao passar ela ao metodo
            CarregaInformacoesEListaElasNaTela(ref listaDeNome);

            //Após carregar as informações e mostrar na tela ele espera um comando
            Console.ReadKey();

            //Indicamos que o usuario precisa informar um número de identificação para pesquisar um registro
            Console.WriteLine("Informe o ID do registro a ser pesquisado.");
            //Aqui como realizamos o registro apenas na chamada
            //Passamos a nossa lista normalmente pois não iremos alterar e apenas pesquisar o informação
            //Após a virgula temos o console readline que espra nosso identificador unico
            PesquisandoInformacoesNaNossaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();

        }

        /// <summary>
        /// Metodo que carrega as infomações dentro da nossa lista criando um metodo "MAIN" e mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">nossa lista a ser carregada</param>
        public static void CarregaInformacoesEListaElasNaTela(ref string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o
            //GetLegth com o parametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Ana_{i}";

            }

            //Lembrando que GetLngth é um metodo e usamos "(parametro)" com parametro ou as vezes sem 
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {

                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }
            Console.ReadKey();


        }
        /// <summary>
        /// Metodo que realiza a pesquisa pelo identificador unico de nossa coleção
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de informaçoes</param>
        /// <param name="pId">Nosso identificador unico</param>
        public static void PesquisandoInformacoesNaNossaLista( string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                    {
                    //Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um metodo
                    //vazio "void" que não espera retornar algo.
                    return;
                }
            }
            //Caso ele passe por esta linha identifiamos que ele nao encontrou resultados compativeis.
            Console.WriteLine("iInfelizmente a busca pelo id nao resultou em nenhuma informação.");
        }
    }
}