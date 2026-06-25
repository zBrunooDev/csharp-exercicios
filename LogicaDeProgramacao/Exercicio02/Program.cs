using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.*/

            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double area = pi * Math.Pow(r, 2);
            
            Console.WriteLine($"A={area:F4}");

        }
    }
}
 