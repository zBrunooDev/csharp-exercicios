using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EmployeeLINQ.Entities;

namespace EmployeeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);;
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        list.Add(new Employee(fields[0], fields[1], double.Parse(fields[2], CultureInfo.InvariantCulture)));
                    }
                }

                var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                Console.WriteLine($"Email of peaple whose salary is more than {limit.ToString("F2", CultureInfo.InvariantCulture)}");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
