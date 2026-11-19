using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = n; i >= 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
