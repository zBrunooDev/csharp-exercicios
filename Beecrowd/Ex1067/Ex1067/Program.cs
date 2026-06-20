using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1067
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int impar;

            for(int i = 1; i <= x; i++)
            {
                if(i % 2 != 0)
                {
                    impar = i;
                    Console.WriteLine($"{impar}");
                }
            }

        }
    }
}
