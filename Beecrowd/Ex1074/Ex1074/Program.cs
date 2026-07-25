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

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (number % 2 == 0)
                {
                    if (number > 0) Console.WriteLine("EVEN POSITIVE");
                    else Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    if (number > 0) Console.WriteLine("ODD POSITIVE");
                    else Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
