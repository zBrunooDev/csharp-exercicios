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

            //Exercicio em andamento.

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
            
            int l = int.Parse(Console.ReadLine());

            // Erro nessa logica aqui.
            for (int i = 0; i < n; i++)
            {
                if( i < n - 1)
                {
                    int a = mat[l, i + 1];
                    mat[l, i + 1] = mat[l, i];
                }
                else
                mat[l, i - i] = mat[l, i];

            }

            for (int i = 0; i < m; i++)
            {
                for(int j = 0;  j < n; j++)
                {
                    Console.Write(mat[i, j]  + " ");
                }
            }

        }
    }
}
