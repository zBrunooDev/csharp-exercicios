using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ListNames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            
            names.Add("Bruno");
            names.Add("Maysa");
            names.Add("Bernardo");
            names.Add("Mauruicio");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine(names.Count);

            string n1 = names.Find(x => x[0] == 'B');
            Console.WriteLine("First: " + n1);

            string n2 = names.FindLast(x => x[0] == 'B');
            Console.WriteLine("Last: " + n2);

            Console.WriteLine();

            names.Remove(names[2]);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(x => x[0] == 'B');

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
