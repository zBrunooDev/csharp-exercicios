using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soma = 0, cont =0;
            int[] vetSoma;
            do
            {
                n = int.Parse(Console.ReadLine());
                do
                {
                    if (n % 2 == 0)
                    {
                        soma += n;
                        cont++;
                    }
                    n++;
                }
                while (cont < 5);
                vetSoma[] = soma;

            }while (n == 0);



        }
    }
}
