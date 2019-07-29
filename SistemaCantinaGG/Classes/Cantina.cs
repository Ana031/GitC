using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG.Classes
{
    public class Cantina
    {
        double saldo = 0;

         public double Saldo { get { return saldo; } }
        public Cantina()
        {
            saldo = 20;
        }

        public bool Retirada(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public double MostrarSaldo()
        {
            return saldo;
        }

    }
}
