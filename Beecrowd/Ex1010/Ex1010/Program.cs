using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string peca1 = Console.ReadLine();
            string peca2 = Console.ReadLine();

            string[] vet1 = peca1.Split(' ');
            string[] vet2 = peca2.Split(' ');

            int numeroPecas1 = int.Parse(vet1[1]);
            double valorPeca1 = double.Parse(vet1[2]);

            int numeroPecas2 = int.Parse(vet2[1]);
            double valorPeca2 = double.Parse(vet2[2]);

            double valorTotal = (numeroPecas1 * valorPeca1) + (numeroPecas2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");

        }
    }
}
