using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            int maior;
            int[] maiores = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                maior = 0;
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < s.Length; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                    if(mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                maiores[i] = maior;
            }

            foreach (int i in maiores)
            {
                Console.WriteLine(i);
            }

        }
    }
}
