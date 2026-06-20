using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1096
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1, j = 7;


            do
            {

                Console.WriteLine($"I={i} J={j}");
                j -= 1;
                Console.WriteLine($"I={i} J={j}");
                j -= 1;
                Console.WriteLine($"I={i} J={j}");

                j = 7;
                i += 2;

            } while (i < 10);

        }
    }
}
