using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, XPositivo, XNegativo;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            delta = Math.Pow(B, 2) - 4*A*C;

            if (A  == 0 || delta <= 0 )
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                XPositivo = (-B + Math.Sqrt(delta)) / (2 * A);

                XNegativo = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine($"R1 = {XPositivo:F5}");
                Console.WriteLine($"R2 = {XNegativo:F5}");
                
            }     

        }
    }
}
 