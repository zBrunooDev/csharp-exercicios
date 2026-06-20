using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int somaPar = 0, cont = 0;

            int[] vet = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
                if (vet[i] % 2 == 0)
                {
                    somaPar += vet[i];
                    cont++;
                }
            }

            int media = somaPar / cont;

            Console.WriteLine(media);


        }
    }
}
