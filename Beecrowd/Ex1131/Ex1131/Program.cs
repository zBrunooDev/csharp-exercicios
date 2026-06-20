using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int inter, gremio, opcao = 1, cont = 0, vitoriaInter = 0, vitoriaGremio = 0, empates = 0;        

            while (opcao == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');

                inter = int.Parse(vet[0]);
                gremio = int.Parse(vet[1]);

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
                while(opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                }

                cont++;

                if (inter > gremio)
                    vitoriaInter++;
                if (inter < gremio)
                    vitoriaGremio++;
                if (inter == gremio)
                    empates++;
            }

            Console.WriteLine($"{cont} grenais");
            Console.WriteLine($"Inter:{vitoriaInter}");
            Console.WriteLine($"Gremio:{vitoriaGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vitoriaInter > vitoriaGremio)         
                Console.WriteLine("Inter venceu mais");
            if (vitoriaInter < vitoriaGremio)
                Console.WriteLine("Gremio venceu mais");
            else if (vitoriaInter == vitoriaGremio)
                Console.WriteLine("Nao houve vencedor");
        }
    }
}
