using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1048
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine());
            double novoSalario, reajuste, percentual;


            if (salario <= 400.00)
            {
                percentual = 15;
            }
            else if (salario <= 800.00)
            {
                percentual = 12;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7;
            }
            else
            {
                percentual = 4;
            }

            reajuste = salario * (percentual / 100.0);
            novoSalario = salario + reajuste;

            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");

        } 
    }
}
