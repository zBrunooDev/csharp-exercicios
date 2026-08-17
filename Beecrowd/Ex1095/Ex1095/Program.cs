using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 60;

            // O laço continua enquanto J for maior ou igual a 0
            while (j >= 0)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3; // I aumenta de 3 em 3
                j -= 5; // J diminui de 5 em 5
            }
        }
    }
}
