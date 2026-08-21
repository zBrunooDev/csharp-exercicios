using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees wil be registered? ");
            int loop = int.Parse(Console.ReadLine());

            Employee employee;

            for( int i = 1; i <= loop; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: R$ ");
                double salary = double.Parse(Console.ReadLine());
                
                employee = new Employee(id, name, salary);

                employees.Add(employee);
                
            }
        }
    }
}
