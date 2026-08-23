using System;
using System.Collections.Generic;
using System.Linq;
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
            names.Add("Mauruicio");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Count);

            string n1 = names.Find(x => x[0] == 'B');
            Console.WriteLine(n1);




        }
    }
}
