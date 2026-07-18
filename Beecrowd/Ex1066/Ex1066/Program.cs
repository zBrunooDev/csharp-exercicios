using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            int contPar = 0, contImpar = 0, contPositivo = 0, contNegativo = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0)
                    contPar++;
                else
                    contImpar++;
                if (vet[i] > 0)
                    contPositivo++;
                else if(vet[i] < 0)
                    contNegativo++;
            }

            Console.WriteLine($"{contPar} valor(es) par(es)");
            Console.WriteLine($"{contImpar} valor(es) impar(es)");
            Console.WriteLine($"{contPositivo} valor(es) positivo(s)");
            Console.WriteLine($"{contNegativo} valor(es) negativo(s)");

        }
    }
}
