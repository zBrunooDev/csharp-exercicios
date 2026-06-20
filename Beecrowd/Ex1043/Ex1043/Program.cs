using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            double[] lados = { a, b, c };
            Array.Sort(lados);

            if (lados[0] + lados[1] > lados[2])
            {
                triangulo = (a + b + c);
                Console.WriteLine($"Perimetro = {triangulo:F1}");
            }
            else
            {
                triangulo = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {triangulo:F1}");
            }

        }
    }
}
