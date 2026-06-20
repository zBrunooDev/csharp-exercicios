using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            double[] media = new double[n];
            string[] s = new string[n];
            

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                nota1[i] = double.Parse(s[1]);
                nota2[i] = double.Parse(s[2]);

                media[i] = (nota1[i] + nota2[i]) / 2;
            }

            Console.WriteLine("Alunos Aprovadoas:");

            for (int i = 0; i < nome.Length; i++)
            {
                if (media[i] >=  6)
                {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}
