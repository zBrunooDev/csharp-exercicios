using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] entry = Console.ReadLine().Split(' ');
            int l = int.Parse(entry[0]);
            int c = int.Parse(entry[1]);
            int[,] mat = new int[l, c];

           

            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0;j < c; j++)
                {
                    if(numb == mat[i, j])
                    {
                        Console.WriteLine($"Position: {i}, {j}");
                    }
                    if (j > 0)
                    {
                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                    }
                    if(i > 0)
                    {
                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                    }
                    if (j < c - 1)
                    {
                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                    }
                    if (i < l - 1)
                    {
                        Console.WriteLine($"Down: {mat[i + 1, j]}");
                    }
                }
            }
        }
    }
}
