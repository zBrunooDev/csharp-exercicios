using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[6];
            int cont = 0, contMedia = 0;
            double somaPositivo = 0, media = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] > 0)
                {
                    cont++;
                    contMedia++;
                    somaPositivo += vet[i]; 
                }
            }

            media = somaPositivo / contMedia;

            Console.WriteLine($"{cont} valores positivos");
            Console.WriteLine($"{media:F1}");

        }
    }
}
