using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            

            for (int i = 1; i <= n; i++)
            {
                double quadrado = (int)Math.Pow(i, 2);
                double cubo = (int)Math.Pow(i, 3);

                Console.WriteLine(i + " " + quadrado + " " + cubo);
                cubo++;
                quadrado++;

                Console.WriteLine($"{i} {quadrado} {cubo}");
            }

        }
    }
}
