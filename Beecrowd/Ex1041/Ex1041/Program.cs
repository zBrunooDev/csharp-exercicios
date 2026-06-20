using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1041
{
    class Program
    {
        static void Main(string[] args)
        {

            float x, y;
            string[] var = Console.ReadLine().Split(' ');

            x = float.Parse(var[0]);
            y = float.Parse(var[1]);

            if(x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0 || y == 0)
            {
                if (x == 0)
                {
                    Console.WriteLine("Eixo Y");
                }
                if (y == 0)
                {
                    Console.WriteLine("Eixo X");
                }
            }
        }
    }
}
