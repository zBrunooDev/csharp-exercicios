using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1080
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 100, max = 0, p_Maior = 0;

            for (int i = 1; i < 101; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (max < numero)
                {
                    max = numero;
                    p_Maior = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(p_Maior);

        }
    }
}
