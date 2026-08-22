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
                int id;
                bool idExist;

                do
                {
                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());
                    idExist = employees.Find(x => x.Id == id) != null;
                    if (idExist)
                    {
                        Console.WriteLine("This ID already exists! Please enter it again.");
                    }

                } while (idExist);     
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: R$ ");
                double salary = double.Parse(Console.ReadLine());
                employee = new Employee(id, name, salary);

                employees.Add(employee);
            }

            Console.Write("Enter the employee ID that will have salary increased: ");
            int employeeId = int.Parse(Console.ReadLine());

            //Employee employeeFind = employees.Find(e => e.Id == employeeId);

            Console.Write("Enter the porcentage: ");
            double porcentage = double.Parse(Console.ReadLine());


        }
    }
}
