using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;

            int opcao = 1;

            while (opcao == 1)
            {
                double nota1 = double.Parse(Console.ReadLine());

                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }

                double nota2 = double.Parse(Console.ReadLine());

                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }
 
                media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media:F2}");
               
                
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());

                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}
