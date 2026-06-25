using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMatrizes07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            int m = int.Parse(Console.ReadLine());
            int n= int.Parse(Console.ReadLine());
           

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            
            int l = int.Parse(Console.ReadLine()) - 1;
            int ultimo = mat[l, n - 1];


            for (int j = n - 1; j > 0; j--)
            {
                mat[l, j] = mat[l, j - 1];
            }

            mat[l, 0] = ultimo;

            for (int i = 0; i < m; i++)
            {
                for(int j = 0;  j < n; j++)
                {
                    Console.Write(mat[i, j]  + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
