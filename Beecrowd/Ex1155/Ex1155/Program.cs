using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1155
{
    class Program
    {

       
        static void Main(string[] args)
        {

            double N = 1;
            for (int i = 2; i <= 100; i++)
            {
                N += 1.0 / i;
            }

            Console.WriteLine($"{N:F2}");
            

        }
    }
}
