using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            double salary = double.Parse(Console.ReadLine());

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = Console.ReadLine().Split(',');
                    list.Add(new Employee(fields[0], fields[1], double.Parse(fields[3])));
                }
            }

            var r1 = list.OrderBy(e => e.Name).Select(e => e.Salary > salary);
            var r2 = list.Select(e => e.Name[0] == 'M');
        }
    }
}
