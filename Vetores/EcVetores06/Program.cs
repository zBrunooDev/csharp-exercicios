using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EcVetores06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int PessoaMaisVelha = 0;

            string[] nomes = new string[n];
            int[] idade = new int[n];

            string[] s = new string[1];

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idade[i] = int.Parse(s[1]); 
            }

            for (int i = 0; i < n; i++)
            {
                if(idade[i] > idade[PessoaMaisVelha])
                {
                    PessoaMaisVelha = i;
                }

            }

            Console.WriteLine($"Pessoa mais velha:{nomes[PessoaMaisVelha]}");

        }
    }
}
