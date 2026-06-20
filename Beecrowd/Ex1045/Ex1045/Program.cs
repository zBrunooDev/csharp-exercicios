using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string[] var = Console.ReadLine().Split(' ');

            double[] lados =
            {
                double.Parse(var[0]),
                double.Parse(var[1]),
                double.Parse(var[2])
            };

            Array.Sort(lados);
            Array.Reverse(lados);

            a = lados[0];
            b = lados[1];
            c = lados[2];

            if(a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (a * a == (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (a * a > (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (a * a < (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || c == b || a == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
