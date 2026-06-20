using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, segundos, horas, minutos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            minutos = (N % 3600) / 60;
            segundos = (N % 3600) % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
