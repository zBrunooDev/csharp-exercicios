using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaA, pessoaB;

            pessoaA = new Pessoa();
            pessoaB = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoaA.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaA.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoaB.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaB.Idade = int.Parse(Console.ReadLine());
            
            if(pessoaA.Idade > pessoaB.Idade)
                Console.WriteLine($"Pessoa mais velha: {pessoaA.Nome}");
            else
                Console.WriteLine($"Pessoa mais velha: {pessoaB.Nome}");

        }
    }
}
