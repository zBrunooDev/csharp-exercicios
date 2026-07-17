using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;

            do
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                    cont++;
                }
                n++;
            } while (cont < 6);

        }
    }
}
