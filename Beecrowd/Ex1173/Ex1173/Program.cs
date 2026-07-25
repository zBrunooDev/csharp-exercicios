using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1173
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vet = new int[10];
            int n = int.Parse(Console.ReadLine());
            vet[0] = n;
            for (int i = 1; i < vet.Length; i++)
            {
                vet[i] = vet[i - 1] * 2;
            }
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
