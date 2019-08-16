using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraBibliotecaDoWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            var listas = new GetFiles();
      
           var listaDeArquivosMeusDocumentos = listas.RetornaArquivosDoMeuDocumentos();
          
           for (int i = 0; i < listaDeArquivosMeusDocumentos.Length; i++)
           {
               Console.WriteLine(listaDeArquivosMeusDocumentos[i]);
           }
          
           Console.ReadKey();
           Console.Clear();

            var listaDeArquivosGit = listas.RetornaArquivosImagesFiles();

            for (int i = 0; i < listaDeArquivosGit.Length; i++)
            {
                Console.WriteLine(listaDeArquivosGit[i]);
            }

            Console.ReadKey();
            Console.Clear();

            var listaDeImagens = listas.RetornaArquivosGit();

            for (int i = 0; i < listaDeImagens.Length; i++)
            {
                Console.WriteLine(listaDeImagens[i]);
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
