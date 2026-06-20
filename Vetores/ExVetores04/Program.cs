using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double media, soma = 0;

            double[] vet = new double [n];
            string[] str = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(str[i]); 
                soma = soma + double.Parse(str[i]);
            }

            media = soma / n;
            Console.WriteLine(media);

            foreach (double i in vet)
            {
                if (i < media)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
