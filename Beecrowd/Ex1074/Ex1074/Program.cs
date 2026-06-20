using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0 && number > 0)
                    Console.Write($"ODD POSITIVE\n");

                else if (number % 2 != 0 && number < 0)
                    Console.Write($"ODD NEGATIVE\n");

                if (number % 2 == 0 && number > 0)
                    Console.WriteLine($"EVEN POSITIVE\n");
                else if (number % 2 == 0 && number < 0)
                    Console.WriteLine($"EVEN NEGATIVE\n");

                if (number == 0)
                    Console.WriteLine($"NULL\n");
            }
        }
    }
}
