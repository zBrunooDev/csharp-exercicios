using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ex2006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tea = int.Parse(Console.ReadLine());

            int[] chose = new int[5];

            string[] strings = Console.ReadLine().Split(' ');

            int contWon = 0;

            for (int i = 0; i < chose.Length; i++)
            {
                chose[i] = int.Parse(strings[i]);
                if (tea == chose[i])
                {
                    contWon++;
                }
            }

            Console.WriteLine(contWon);
        }
    }
}
