using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if(x == 2)
                {
                    Console.WriteLine($"{x} eh primo");
                }
                else if(x % 2 == 0)
                {
                    Console.WriteLine($"{x} nao eh primo");
                }
                else
                {
                    bool ehPrimo = true;    
                    for (int j = 3; j <= Math.Sqrt(x); j += 2)
                    {
                        if (x % j == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                    if(ehPrimo == true)
                    {
                        Console.WriteLine($"{x} eh primo");
                    }
                    else
                    {
                        Console.WriteLine($"{x} nao eh primo");
                    }
                }
            }

        }
    }
}
