using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1099
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê a quantidade de casos de teste
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // Lê a linha com os dois valores, divide pelo espaço e converte para inteiro
                string[] entrada = Console.ReadLine().Split(' ');
                int x = int.Parse(entrada[0]);
                int y = int.Parse(entrada[1]);

                // Determina qual é o menor e qual é o maior número
                int menor = Math.Min(x, y);
                int maior = Math.Max(x, y);

                int somaImpares = 0;

                // O loop começa a partir do (menor + 1) e vai até antes do maior
                // garantindo que os valores de X e Y não entrem na soma (apenas os números ENTRE eles)
                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        somaImpares += j;
                    }
                }

                // Exibe o resultado de cada caso de teste
                Console.WriteLine(somaImpares);
            }
        }
    }
}
