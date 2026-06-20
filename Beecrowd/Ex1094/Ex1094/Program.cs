using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1094
{
    class Program
    {
        static void Main(string[] args)
        {

            int casos = int.Parse(Console.ReadLine());
            int somaRato = 0, somaCoelho = 0, somaSapo = 0, totalCobaias;
            double porcentoRato, porcentoCoelho, porcentoSapo;


            for (int i = 0; i < casos; i++)
            {

                string[] vet = Console.ReadLine().Split(' ');
                if (vet[1] == "C")
                {
                    somaCoelho += int.Parse(vet[0]);
                }
                if (vet[1] == "R")
                {
                    somaRato += int.Parse(vet[0]);
                }
                if (vet[1] == "S")
                {
                    somaSapo += int.Parse(vet[0]);
                }

            }

            totalCobaias = somaCoelho + somaRato + somaSapo;

            porcentoCoelho = ((double)somaCoelho / totalCobaias) * 100.0;
            porcentoRato = ((double)somaRato / totalCobaias) * 100.0;
            porcentoSapo = ((double)somaSapo / totalCobaias) * 100.0;

            Console.WriteLine($"Total: {totalCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {somaCoelho}");
            Console.WriteLine($"Total de ratos: {somaRato}");
            Console.WriteLine($"Total de sapos: {somaSapo}");
            Console.WriteLine($"Percentual de coelhos: {porcentoCoelho:F2} %");
            Console.WriteLine($"Percentual de ratos: {porcentoRato:F2} %");
            Console.WriteLine($"Percentual de sapos: {porcentoSapo:F2} %");
        }
    }
}
