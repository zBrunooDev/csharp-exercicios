using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1175
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] n = new int[20];

            for (int i = 0; i < n.Length; i++)
            {
                int y = int.Parse(Console.ReadLine());
                n[i] = y;
            }

            for (int i = 0; i < 10; i++)
            {
                int temp = n[i];
                n[i] = n[19 - i];
                n[19 - i] = temp;
            }

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {n[i]}");
            }

        }
    }
}
