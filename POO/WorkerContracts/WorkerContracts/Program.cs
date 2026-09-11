using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorkerContracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament´s name: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Enter the worker data: ");

            // Enter data of worker
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: (Junior / MidLevel / Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int contContract = int.Parse(Console.ReadLine());

            Departament departament = new Departament(depName);

            Worker worker = new Worker(name, level, baseSalary, departament);

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

                HourContract contract = new HourContract(data, valuePerHouer, duration);
                worker.addContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament {worker.Departament.Name}");

            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month):F2}");

        }

    }
}
