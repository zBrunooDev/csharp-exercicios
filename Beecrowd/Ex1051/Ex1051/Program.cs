using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());

            if(salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if(salario > 2000 && salario <= 3000)
            {
                double imposto = salario - 2000;
                imposto = imposto * 0.08;
                Console.WriteLine($"R$ {imposto:F2}");
            }
            else if (salario > 3000 && salario <= 4500)
            {
                double imposto = salario - 2000; // Valor insento
                imposto = imposto - 1000; // valor de 8%
                imposto = imposto * 0.18 + 80; // imposto da casa dos 18% + 8%

                Console.WriteLine($"R$ {imposto:F2}");
            }
            else if (salario > 4500)
            {
                double imposto = salario - 2000; // Valor insento
                imposto -= 1000; // valor de 8%
                imposto -= 1500; // imposto de 18%
                imposto = imposto * 0.28 + 80 + 270; // imposto da casa dos 18% + 8%

                Console.WriteLine($"R$ {imposto:F2}");
            }
        }
    }
}
