using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjectForms.Model
{
    public class LivroC : Informacao
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string ISBN { get; set; }
        public int Genero { get; set; }
        public int Editora { get; set; }
        public string Sinopse { get; set; }
        public string Observacoes { get; set; }       
    }
}
