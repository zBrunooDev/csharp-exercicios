using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros;
            double maior = 0;
            int maiorPosição = 0;

            int n = int.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');

            numeros = new double[n];

            for (int i = 0; i < n; i++)
            {  
                numeros[i] = double.Parse(vet[i]);
            }

            for(int i = 0; i < n; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    maiorPosição = i;
                }
            }

            Console.WriteLine($"{maior:F1}");
            Console.WriteLine($"{maiorPosição}");

        }
    }
}
