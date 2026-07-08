using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");  
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {funcionario.Nome}, {funcionario.SalarioLiquido():F2}");

            Console.Write("Digite a porcentagem para aumentar o sálario: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados Atualizados: {funcionario.Nome}, {funcionario.AumentarSalario(porcentagem)}");

            
        }
    }
}
