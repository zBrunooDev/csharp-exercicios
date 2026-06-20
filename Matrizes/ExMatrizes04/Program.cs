using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExMatrizes04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < s.Length; j++)
                {
                    mat[i,j] = int.Parse(s[j]);
                    if(i < j)
                    {
                        soma += mat[i, j];
                    }
                }
            }

            Console.WriteLine(soma);

        }
    }
}
