using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEsolarComClass
{
    public class ListarRegistros
    {
        string[,] arrayAluno = new string[5, 5];
        Boletim boletim = new Boletim();



        public string MenuDeEscolha()
        {
            Console.Clear();
            Console.WriteLine("             >> MENU <<\n");
            Console.WriteLine(">> DIGITE O NÚMERO DA OPÇÃO DESEJADA <<\n");
            Console.WriteLine("1 - Inserir um novo cadastro de aluno.");
            Console.WriteLine("2 - Remover cadastro de aluno.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.ReadKey();
            return Console.ReadLine();
            
        }

        public  void CarregaInformacoesNaTela()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                arrayAluno[i, 0] = i.ToString();

                Console.WriteLine("INSIRA O NOME DESEJADO");
                arrayAluno[i, 1] = Console.ReadLine();
      
                Console.WriteLine("\r\nINSIRA NOTAS PARA ESSE ALUNO");             
                Console.WriteLine("Pirmeira Nota");
                var nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Segunda Nota");
                var nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Terceira Nota");
                var nota3 = Convert.ToDouble(Console.ReadLine());

                var media = boletim.NotasAluno(nota1, nota2, nota3);
                arrayAluno[i, 2] = media.ToString();

                Console.WriteLine("\r\nTotal de Aulas");
                var totalAulas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\r\nTotal de Faltas");
                var totalFaltas = Convert.ToInt32(Console.ReadLine());

                var frequencia = boletim.Frequencia(totalAulas, totalFaltas);
                arrayAluno[i, 3] = frequencia.ToString();

                arrayAluno[i, 4] = boletim.retornaResultado(media, frequencia).ToString();


                PesquisandoIdLista();

                Console.Clear();
            }

            Console.ReadKey();
        }
        public void PesquisandoIdLista()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {             
                {
                    Console.WriteLine($"Informação escolhida: Id:{arrayAluno[i, 0]} " +
                        $"- Nome:{arrayAluno[i, 1]} > Media:{arrayAluno[i, 2]} " +
                        $"> Frequencia {arrayAluno[i, 3]}%" +
                        $"> Estado {arrayAluno[i,4]}");
                }
            }

            Console.WriteLine("iInfelizmente a busca pelo id nao resultou em nenhuma informação.");
            Console.ReadKey();
        }
    }
}

