using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStatic_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.Dolar(cot, valor):F2}");

        }
    }
}
