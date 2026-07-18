using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1158
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vetSomas = new int[n];

            for (int i = 0; i < n; i++)
            {
                int cont = 0, soma = 0;
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                do
                {

                    if(x % 2 != 0)
                    {
                        soma += x;
                        cont++;
                    }
                    x++;

                } while (cont < y);
                
                vetSomas[i] = soma;
            }

            for (int i = 0;i < n;i++)
            {
                Console.WriteLine(vetSomas[i]);
            }
        }
    }
}
