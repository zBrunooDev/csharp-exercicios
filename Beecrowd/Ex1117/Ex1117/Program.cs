using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota, somaNotas = 0;
            int notasValidas = 0;

            while (notasValidas < 2)
            {
                nota = double.Parse(Console.ReadLine());

                // Verifica se a nota está no intervalo permitido (0 a 10)
                if (nota >= 0.0 && nota <= 10.0)
                {
                    somaNotas += nota;
                    notasValidas++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            // Calcula e exibe a média com duas casas decimais
            double media = somaNotas / 2.0;
            Console.WriteLine($"media = {media:F2}");
        }
    }
    }
}
