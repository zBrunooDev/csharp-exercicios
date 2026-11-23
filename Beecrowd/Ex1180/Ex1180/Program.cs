using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] values = new int[n];
           
            string[] numbs = Console.ReadLine().Split(' ');

            values[0] = int.Parse(numbs[0]);
            int min = values[0];
            int p = 0;

            for (int i = 1; i < n; i++)
            {
                values[i] = int.Parse(numbs[i]);

                if (values[i] < min)
                {
                    min = values[i];
                    p = i;
                }
            }

            Console.WriteLine("Menor valor: " + min);
            Console.WriteLine("Posicao: " + p);

        }
    }
}
