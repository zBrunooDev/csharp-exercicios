using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExMatrizes02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int soma;
            int[] vetSoma = new int[n];

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                soma = 0;
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                    soma += mat[i, j];
                }
                vetSoma[i] = soma;
            }

            foreach (int i in vetSoma)
            {
                Console.WriteLine(i);
            }            
        }
    }
}
