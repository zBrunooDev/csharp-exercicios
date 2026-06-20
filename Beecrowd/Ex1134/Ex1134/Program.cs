using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1134
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (N != 4)
            {

                if (N == 1)
                    alcool++;
                if (N == 2)
                    gasolina++;
                if (N == 3)
                    diesel++;

                N = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");

            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}
