using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1097
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1, j = 7;

            for (i = 1; i < 10; i += 2)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");

                j = j + 4;

            }

        }
    }
}
