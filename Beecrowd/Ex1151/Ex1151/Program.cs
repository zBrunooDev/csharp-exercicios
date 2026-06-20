using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1151
{
    class Program
    {
        static void Main(string[] args)
        { 
            int N = int.Parse(Console.ReadLine());

            if (N > 0)
            {
                int anterior = 0;
                int atual = 1;

                // Imprime o primeiro elemento sem espaço antes
                Console.Write(anterior);

                // Gera e imprime os próximos N-1 elementos
                for (int i = 1; i < N; i++)
                {
                    Console.Write(" " + atual);

                    int proximo = anterior + atual;
                    anterior = atual;
                    atual = proximo;
                }

                // Quebra de linha obrigatória no fim (requisito do URI)
                Console.WriteLine();
            }
        }
    }
}

