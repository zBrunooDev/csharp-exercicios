using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExMatrizes06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];
            double soma = 0;

            // Prerenchimento do vetor

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = double.Parse(s[j]);

                    // A) calcular e imprimir a soma de todos os elementos positivos da matriz.
                    if (mat[i, j] >= 0)
                    {
                        soma += mat[i, j];
                    }
                }
            }

            // b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
            // c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna. 

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA DOS POSITIVOS: {soma}");

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mat[linha, i]:F1} ");
            }
            Console.WriteLine();


            Console.Write("COLUNA ESCOLHIDA: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{mat[j, coluna]:F1} ");
            }
            Console.WriteLine();

            // d) imprimir os elementos da diagonal principal da matriz.
            Console.Write("DIAGONAL PRINCIPAL: ");
            for(int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{mat[i, j]:F1} ");
                    }
                }
            }
            Console.WriteLine() ;

            // e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada 


            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.Write($"{Math.Pow(mat[i, j], 2):F1} ");
                    }
                    else
                    Console.Write($"{mat[i,j]:F1} ");
                }
                Console.WriteLine();
            }

        }
    }
}
