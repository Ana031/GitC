using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEsolarComClass
{
    public class Boletim
    {
        public double NotasAluno(double Nota1, double Nota2, double Nota3)
        {
            
            return ((Nota1 + Nota2  + Nota3) / 3);        
        }
        
        public double Frequencia(int TotalDeAulas, int Faltas)
        {
            return ((TotalDeAulas - Faltas) * 100) / TotalDeAulas;
        }

        public void Resultado(int NotasAluno, int Frequencia)
        {        
            if ((NotasAluno >= 7) && (Frequencia >=75))
            {
                Console.WriteLine($"Aluno aprovado com media {NotasAluno} e frequencia de {Frequencia}%");
            }
            else
            {
                Console.WriteLine($"Aluno reprovado com media {NotasAluno} e frequencia de {Frequencia}%");
            }
        }

        public string retornaResultado(double NotasAluno, double Frequencia)
        {
            if ((NotasAluno >= 7) && (Frequencia >= 75))
            {
                return "Aprovado";
            }
            return "Reprovado";

            
        }
    }
}
