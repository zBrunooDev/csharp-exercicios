using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] tabuada = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] resultado = new int[10];

            for (int i = 0; i < tabuada.Length; i++)
            {
                resultado[i] = tabuada[i] * n;
            }
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine($"{i + 1} x {n} = {resultado[i]}");
            }

        }
    }
}
