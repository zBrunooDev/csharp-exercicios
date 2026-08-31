using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);

            for (int i = 1; i <= n2; i++)
            {
                if (i % n1 == 0)
                {
                    Console.WriteLine(i); 
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
