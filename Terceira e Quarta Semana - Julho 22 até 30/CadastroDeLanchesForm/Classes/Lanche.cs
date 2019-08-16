using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeLanchesForm.Classes
{
    public class Lanche
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public DateTime DatInc { get; set; } = DateTime.Now;
    }
}
