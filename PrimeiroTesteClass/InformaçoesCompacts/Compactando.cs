using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroTesteClass.InformaçoesCompacts
{
    public class Compactando
    {
        string[] lista;
        public Compactando()
        {
            lista = new string[10];
                                                                                        //Ao chamar este metodo no construtor nossa lista ja vai estar carregada 
                                                                                        //ao iniciar a istancia "jogar para memoria"
            CarregarLista();
        }
        public void CarregarLista()
        {
                                                                                        //laço que usamos para andar sobre as posiões da nossa lista
            for (int i = 0; i < lista.Length; i++)
            {
                                                                                        //carregando os valores da nossa lista aqui
                                                                                        //onde "i" representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                                                                                        //DateTime é um tipo do .net c# que disponibiliza funções relacionadas a datas
                                                                                        //e horas, ou seja, se precisar trabalar com essas informações é possível usar esse cara.
            }
                                                                                        //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista)                                                 //"var item" indica uma unidade da nossa lista "in lista"
                                                                                        //indica a lista que desejamos varrer
            Console.WriteLine(item);                                                    //Aqui apresentamos essa informação na tela
            Console.ReadKey();
        }
    }
}
