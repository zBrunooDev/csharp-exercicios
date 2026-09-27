using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] n = Console.ReadLine().Split(' ');

                int x = int.Parse(n[0]);
                int y = int.Parse(n[1]);

                if(x == y)
                {
                    break;
                }

                if (x > y) { Console.WriteLine("Decrescente"); }
                else { Console.WriteLine("Crescente"); }

            }

        }
    }
}
