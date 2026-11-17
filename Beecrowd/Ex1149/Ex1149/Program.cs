using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);
            int n = 0;

            for (int i = 1; i < valores.Length; i++)
            {
                int atual = int.Parse(valores[i]);
                if (atual > 0)
                {
                    n = atual;
                    break;
                }
            }
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += a + i;
            }

            Console.WriteLine(soma);
        
        }
    }
}
