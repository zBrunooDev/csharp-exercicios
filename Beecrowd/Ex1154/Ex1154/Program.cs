using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, someIdade = 0;
            int idade = int.Parse(Console.ReadLine());
            double media;

            while(idade >= 0)
            {
                cont++;
                someIdade = someIdade + idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) someIdade / cont;

            Console.WriteLine($"{media:F2}");

        }
    }
}