using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExtensionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of extension methods for the DateTime type.
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            // Example of extension methods for the String type.
            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10)); 

        }
    }
}
