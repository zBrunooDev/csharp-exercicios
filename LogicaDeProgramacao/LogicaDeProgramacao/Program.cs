using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LogicaDeProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EX 1.1

            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.*/

            double[,] mat = new double[2, 3];
            double soma = 0;

            for(int i = 0; i < 2; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < 3; j++)
                {
                    mat[i, j] = double.Parse(s[j]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                soma += mat[i, 1] * mat[i, 2];
            }

            Console.WriteLine($"VALOR A PAGAR: R${soma:F2}");

        }
    }
}
