using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Manualmente
namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da nossa lista
            string[,] listaDeNomes = new string[10, 2];
            //Aqui vamos criar uma forma de identificar nossos registros
            int IdParaLista = 0;
            //Chamada do nosso metodo para inserir registro  passando por meio de referencia
            //nossos dois itens, lista de nomes, e nosso identificador unico
            InsereRegistro(ref listaDeNomes, ref IdParaLista);

            Console.ReadKey();
            //Aqui acionamos novamente nosso inserir registro
            InsereRegistro(ref listaDeNomes, ref IdParaLista);

            Console.ReadKey();
        }

        public static void InsereRegistro(ref string[,] listaDeNome, ref int IdParaLista)
        {
            //Aqui estaremos em um laço para informar nssos registros
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                //Aqui definimos que o mesmo deve continuar para o proximo registro
                //Pois esse registro ja esta ocupado
                if (listaDeNome[i, 0] != null)
                    continue;
                //Indicamso que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("\r\nInforma um nome para adicionar um registro:");
                var nome = Console.ReadLine();

                //Criamos o nosso identficador unico com o obeto externo que 
                //mesmo após sairmos do nosso laço ainda podera sr incrementado
                listaDeNome[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos nosso nome na lista
                listaDeNome[i, 1] = nome;

                //Identificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
                Console.WriteLine("Deseja inserir um novo registro? Sim(1) Não(0)");
                //O readKey so espera uma unica tecla e nos retorna a tecla que foi acionada e nao o valor dela 
                //Por isso usamos o KeyChar para pegar esse valor e converter ele em um string para comparação
                var continuar = Console.ReadKey().KeyChar.ToString();
                //Aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro ate que a nossa
                //lista esteja completa de informações
                if (continuar == "0")
                    break; //Break é uma palavra reservada do C# que para, por isso brak, todo laço de repetição
                //ou sequenciador logico

                //Terceira camada da deepWeb
                AumentaTamanhoDeLista(ref listaDeNome);

            }

            Console.WriteLine("Registro adicionado com sucesso! Segue lista de informações adicionais:");
            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele faz da mesma forma que o sifrão
                //a diferença entre eles é que esta é um cara em grande quantidades
                //acaba sendo mais rapido
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1}", listaDeNome[i, 0], listaDeNome[i, 1]));



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
                }
                //Indicamos que nesse ponto a lista foi atualizada em seu tamanho
                Console.WriteLine("O tamanho da lista foi atualizado:");
            }
            
        }
    }

}
