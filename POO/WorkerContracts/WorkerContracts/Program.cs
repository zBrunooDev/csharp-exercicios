using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerContracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament´s name: ");
            string departament = Console.ReadLine();
            Console.WriteLine("Enter the worker data: ");

            // Enter data of worker
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: (Junior / MidLevel / Senior): ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int contContract = int.Parse(Console.ReadLine());

            // loop for fill data contracts

            for (int i = 1; i <= contContract; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHouer = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

            }

        }

    }
}
