using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1014
{
    class Program
    {
        static void Main(string[] args)
        {

            double km, combustivel;

            km = double.Parse(Console.ReadLine());
            combustivel = double.Parse(Console.ReadLine());

            double consumo = km / combustivel;

            Console.WriteLine($"{consumo:F3} km/l");

        }
    }
}
