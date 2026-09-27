using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1098
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i2 = 0; i2 <= 20; i2 += 2)
            {
                double i = i2 / 10.0;

                for (int jCount = 1; jCount <= 3; jCount++)
                {
                    double j = jCount + i;

                    if (i2 == 0 || i2 == 10 || i2 == 20)
                    {
                        Console.WriteLine($"I={i:0} J={j:0}");
                    }
                    else
                    {
                        Console.WriteLine($"I={i:0.0} J={j:0.0}");
                    }
                }
            }
        }
    }
}
