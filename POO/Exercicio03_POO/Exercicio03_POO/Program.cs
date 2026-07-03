using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine());
            retangulo.Largura = double.Parse(Console.ReadLine());


            Console.WriteLine($"AREA {retangulo.Area()}");
            Console.WriteLine($"PERÍMETRO {retangulo.Perimetro()}");
            Console.WriteLine($"DIAGONAL {retangulo.Diagonal()}");
        }
    }
}
