using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1564
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine("vai ter copa!");
                }
                else if(n > 0)
                {
                    Console.WriteLine("vai ter duas!");
                }
            }

        }
    }
}
