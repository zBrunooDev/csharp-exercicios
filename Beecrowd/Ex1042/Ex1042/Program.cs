using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex1042
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');

            int[] valores =
            {
                int.Parse(vet[0]),
                int.Parse(vet[1]),
                int.Parse(vet[2])
            };

            int[] valoresOrganizados =
            {
                int.Parse(vet[0]),
                int.Parse(vet[1]),
                int.Parse(vet[2])
            };

            Array.Sort(valoresOrganizados);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{valoresOrganizados[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{valores[i]}");
            }
        }
    }
}
