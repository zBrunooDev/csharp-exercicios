using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1038
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveid

            int Codigo, Quantidade;
            double valorTotal = 0.0;

            string[] vet = Console.ReadLine().Split(' ');

            Codigo = int.Parse(vet[0]);
            Quantidade = int.Parse(vet[1]);

            switch (Codigo)
            {
                case 1:
                    valorTotal = 4.00 * Quantidade;
                    break;
                case 2:
                    valorTotal = 4.50 * Quantidade;
                    break;
                case 3:
                    valorTotal = 5.00 * Quantidade;
                    break;
                case 4:
                    valorTotal = 2.00 * Quantidade;
                    break;
                case 5:
                    valorTotal = 1.50 * Quantidade;
                    break;
            }

            Console.WriteLine($"Total: R$ {valorTotal:F2}");
        }
    }
}
