using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[6];
            int cont = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] > 0)
                {
                    cont++;
                }
            }

            Console.WriteLine($"{cont} valores positivos");
        }
    }
}
