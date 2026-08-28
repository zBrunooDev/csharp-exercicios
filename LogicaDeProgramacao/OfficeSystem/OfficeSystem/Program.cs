using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sitema  de marcação de tempo");

            Console.Write("Entrada: ");
            DateTime entrada = DateTime.Parse(Console.ReadLine());

            Console.Write("Saída para almoço: ");
            DateTime saidaAlmoco = DateTime.Parse(Console.ReadLine());

            Console.Write("Volta do almoço: ");
            DateTime voltaAlmoco = DateTime.Parse(Console.ReadLine());

            Console.Write("Saída: ");
            DateTime saida = DateTime.Parse(Console.ReadLine());



        }

    }
}
