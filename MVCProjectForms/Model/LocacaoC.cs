using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjectForms.Model
{
    public class LocacaoC : Informacao
    {
        public int Id { get; set; }
        public int Livro { get; set; }
        public int Usuario { get; set; }
        public int Tipo { get; set; }
        public DateTime Devolucaod { get; set; } 
    }
}
