using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ExMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int m, n;

            string[] s = Console.ReadLine().Split(' ');

            m = int.Parse(s[0]);
            n = int.Parse(s[1]);

            int[,] mat = new int[m, n];
            

            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(s[j]);
                    
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0;i < m; i++)
            {
                for(int j = 0; j < n;j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }

        }
    }
}
