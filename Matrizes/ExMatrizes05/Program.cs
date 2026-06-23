using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMatrizes05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Captura dos valores das ma3trizes
            string[] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            int[,] matA = new int[a, b];
            int[,] matB = new int[a, b];
            int[,] matSoma = new int[a, b];
            
            //Preenchimento Matriz A
            for(int i = 0; i < a; i++)
            {
                s = Console.ReadLine().Split();
                for (int j = 0; j < b; j++)
                {
                    matA[i, j] = int.Parse(s[j]); 
                }
            }

            //Preenchimento Matriz B
            for (int i = 0; i < a; i++)
            {
                s = Console.ReadLine().Split();
                for (int j = 0; j < b; j++)
                {
                    matB[i, j] = int.Parse(s[j]);
                }
            }

            // Calculo das matrizes e print do resultado.
            for (int i = 0;i < a; i++)
            {
                for (int j = 0;j < b; j++)
                {
                    matSoma[i, j] = matA[i, j] + matB[i, j];
                    Console.Write(matSoma[i, j] + ' ');
                }
                Console.WriteLine();
            }

            
        }
    }
}
