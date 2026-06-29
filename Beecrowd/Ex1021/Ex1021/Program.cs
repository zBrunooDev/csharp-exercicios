using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] notas = new double[] { 100, 50, 20, 10, 5, 2 };
            double[] moedas = new double[] { 1.0, 0.50, 0.25, 0.10, 0.05, 0.01 };

            double[] quantidadeNotas = new double[notas.Length];
            double[] quantidadeMoedas = new double[moedas.Length];

            //Processamento

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] <= valor)
                {
                    quantidadeNotas[i] = Math.Truncate(valor / notas[i]);
                    valor = Math.Round(valor % notas[i], 2);
                }
            }

            for (int i = 0; i < moedas.Length; i++)
            {
                if (moedas[i] <= valor)
                {
                    quantidadeMoedas[i] = Math.Truncate(valor / moedas[i]);
                    valor = Math.Round(valor % moedas[i], 2);
                }
            }


            // print na tela

            Console.WriteLine("NOTAS:");
            for (int i = 0; i < quantidadeNotas.Length; i++)
            {
                Console.WriteLine($"{quantidadeNotas[i]:F0} nota(s) de R$ {notas[i]:F2}");
            }
            Console.WriteLine("MOEDAS:");
            for (int i = 0; i < quantidadeMoedas.Length; i++)
            {
                Console.WriteLine($"{quantidadeMoedas[i]:F0} moeda(s) de R$ {moedas[i]:F2}");
            }
        }
    }
}
