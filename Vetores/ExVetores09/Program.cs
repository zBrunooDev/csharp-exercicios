using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] mercadoria = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            int contAbaixo = 0, contEntre = 0, contAcima = 0; 
            double totalCompra = 0, totalVenda = 0;

            string[] s = new string[n];

            // Preenchimento das variaveis

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                mercadoria[i] = s[0];
                precoCompra[i] = double.Parse(s[1]);
                precoVenda[i] = double.Parse(s[2]);

                double lucro = precoVenda[i] - precoCompra[i];

                double percentual = lucro * 100 / precoCompra[i];

                if (percentual < 10)
                {
                    contAbaixo++;
                }
                else if (percentual >= 10 && percentual <= 20)
                {
                    contEntre++;
                }
                else
                {
                    contAcima++;
                }

                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];           

            }

            double lucroTotal = totalVenda - totalCompra;

            Console.WriteLine($"Lucro abaixo de 10%: {contAbaixo}");
            Console.WriteLine($"Lucro entre de 10% e 20%: {contEntre}");
            Console.WriteLine($"Lucro acima de 20%: {contAcima}");
            Console.WriteLine($"Valor total de compra: {totalCompra:F2}");
            Console.WriteLine($"Valor total de Venda: {totalVenda:F2}");
            Console.WriteLine($"Lucro total: {lucroTotal:F2}");

        }
    }
}
