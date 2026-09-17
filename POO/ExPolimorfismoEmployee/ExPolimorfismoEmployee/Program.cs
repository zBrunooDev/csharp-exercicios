using ExPolimorfismoEmployee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismoEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n) ?");
                char option = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = int.Parse(Console.ReadLine());

                if (option == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = int.Parse(Console.ReadLine());

                    employees.Add(new OutsourcedEmployee(name, hour, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hour, valuePerHour));
                }

            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment():F2}");
            }

        }
    }
}
