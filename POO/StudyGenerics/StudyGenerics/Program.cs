using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Here we instantiate the class with the type we want to use.
            // If we need another type, we just change the type during instantiation.

            PrintService<string> printService = new PrintService<string>();

            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());


        }
    }
}
