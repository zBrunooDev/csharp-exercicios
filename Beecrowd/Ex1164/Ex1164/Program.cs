using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1164
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int casos = int.Parse(Console.ReadLine());


            for (int i = 0; i < casos; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int soma = 0;

                for (int j = 1; j <= n / 2; j++)
                {
                    if (n % j == 0)
                    {
                        soma += j;
                    }
                }

                if (soma == n)
                    Console.WriteLine($"{n} eh perfeito");
                else
                    Console.WriteLine($"{n} nao eh perfeito");
            }
        }
    }
}
