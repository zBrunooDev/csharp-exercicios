using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string[] n = Console.ReadLine().Split(' ');

                int x = int.Parse(n[0]);
                int y = int.Parse(n[1]);

                if (x <= 0 || y <= 0)
                {
                    break;
                }

                int maior = Math.Max(x, y);
                int menor = Math.Min(x, y);

                int sum = 0;
                for (int i = menor; i <= maior; i++)
                {
                    sum += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + sum);

            }

        }
    }
}
