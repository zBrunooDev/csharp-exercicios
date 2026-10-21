using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSetStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();
            HashSet<int> d = new HashSet<int>();

            ReaderCodeStudents("A", a);
            ReaderCodeStudents("B", b);
            ReaderCodeStudents("C", c);

            d.UnionWith(a);
            d.UnionWith(b);
            d.UnionWith(c);

            Console.WriteLine();
            Console.WriteLine("Total students: " + d.Count);
        }

        static void ReaderCodeStudents(string course, HashSet<int> collection)
        {
            Console.Write($"How Many student for course {course}:");
            int loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                int studentCode = int.Parse(Console.ReadLine());
                collection.Add(studentCode);
            }
        }
    }
}
