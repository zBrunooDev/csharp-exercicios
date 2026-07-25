using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ex1174
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            double[] vet = new double[100];
            for(int i =  0; i < vet.Length; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] < 0 || vet[i] == 10)
                {
                    Console.WriteLine($"A[{i}] = {vet[i]:F1}");
                }
            }

        }
    }
}
