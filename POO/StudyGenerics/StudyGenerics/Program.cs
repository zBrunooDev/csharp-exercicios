using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // O problema relacionado à reutilização de código é que, se quisermos imprimir valores de tipos diferentes, como int e string, precisaríamos reescrever o método para cada tipo

            // Utilizar object não resolve completamente o problema, pois pode exigir conversões de tipo e permitir erros em tempo de execução. Além disso, pode prejudicar o desempenho em alguns cenários.

            PrintService printService = new PrintService();

            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());


        }
    }
}
