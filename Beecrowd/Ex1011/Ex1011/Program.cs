using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double pi = 3.14159;
            double volume = (4/ 3.0) * pi * (Math.Pow(r, 3));

            Console.WriteLine($"VOLUME = {volume:F3}");

        }
    }
}
