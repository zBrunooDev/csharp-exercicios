using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4;

            string[] var = Console.ReadLine().Split(' ');
            n1 = float.Parse(var[0]);
            n2 = float.Parse(var[1]);
            n3 = float.Parse(var[2]);
            n4 = float.Parse(var[3]);

            float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);

            if (media >= 7.0)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                double mediaTruncada = Math.Truncate(media * 10) / 10;
                Console.WriteLine($"Media: {mediaTruncada:F1}");
                Console.WriteLine("Aluno reprovado.");
            }
            else if(media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno em exame.");

                float notaExame = float.Parse(Console.ReadLine());

                Console.WriteLine($"Nota do exame: {notaExame:F1}");

                float mediaFinal = (media + notaExame) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
            }
        }
    }
}
