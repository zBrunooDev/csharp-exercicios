using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStatic_POO
{
    internal class ConversorDeMoeda
    {
        static double IOF = 0.06;
        public static double Dolar(double dolar, double valor)
        {
            dolar += dolar * IOF;
            return dolar * valor;
        }
    }
}
