using ExTaxPayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTaxPayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data");

                Console.Write("Individual or Company? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual income: ");
                double incomeAnnual = double.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine());

                    taxPayers.Add(new Individual(name, incomeAnnual, healthSpending));
                }
                else if(ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, incomeAnnual, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sumTax = 0;

            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
                sumTax += taxPayer.TaxCalcultion();
            }

            Console.WriteLine("TOTAL TAXES: $ " + sumTax.ToString("F2"));

        }
    }
}
