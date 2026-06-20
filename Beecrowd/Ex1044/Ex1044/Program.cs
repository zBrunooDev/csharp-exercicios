using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, maior, menor;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A > B)
            {
                maior = A;
                menor = B;
            }        
            else
            {
                maior = B;
                menor = A;
            }

            if (maior % menor == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");

        }
    }
}
