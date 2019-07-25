using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoletimEsolarComClass;


namespace GestroEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            ListarRegistros cad = new ListarRegistros();

            cad.MenuDeEscolha(); 
            Console.Clear();
            cad.CarregaInformacoesNaTela();
            cad.PesquisandoIdLista();

            Console.ReadKey();

        }

    }
}
