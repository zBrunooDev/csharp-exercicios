using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu ano de nascimento: ");
            string nascimento = Console.ReadLine();

            DateTime date = DateTime.Now;
            DateTime nascimentoFormatada;

            if (DateTime.TryParse(nascimento, out nascimentoFormatada))
            {
                Console.WriteLine(nascimentoFormatada.ToString("dd/MM/yyyy"));

                int idade = date.Year - nascimentoFormatada.Year;
                if (nascimentoFormatada.Date > date.AddYears(-idade))
                {
                    idade--;
                }
                Console.WriteLine($"Idade: {idade} anos");
            }
            else
            {
                Console.WriteLine("Data de nascimento inválida.");
            }
        }
    }
}
