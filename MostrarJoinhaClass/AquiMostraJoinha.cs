using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        /// <summary>
        /// Metodo que mostra o joinha escrito
        /// </summary>
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui esta iniciando o joinha");

            Console.ReadKey();
        }
        /// <summary>
        /// Aqui nao bebe mais que eu
        /// </summary>
        /// <param name="eQuinta">2.0 ainda faz 3 por 1</param>
        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("Carai mermão");
            else
                Console.WriteLine("aaiaiaiai");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que vamos identificar o tipo
        /// </summary>
        /// <returns></returns>
        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1", "Teste 2" };
        }
    }
}
