using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1073
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    double quadradoPares = Math.Pow(i, 2);
                    Console.WriteLine($"{i}^2 = {quadradoPares}");
                }    
            }

        }
    }
}
