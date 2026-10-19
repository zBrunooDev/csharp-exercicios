using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyHashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of a HashSet collection.
            // HashSet does not guarantee the order of its elements. It also prevents duplicate elements.
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));  // Checks whether the collection contains "Notebook". Returns true or false.
            foreach (String p in set)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            // Example of a SortedSet collection.
            // SortedSet keeps its elements sorted and prevents duplicates.
            // UnionWith, IntersectWith, and ExceptWith modify the collection
            // on which they are called.

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // Union example
            SortedSet<int> c = new SortedSet<int>(a); 
            c.UnionWith(b);
            printCollection(c); // Shows the union of collections a and b. Combines the values without duplicates.

            // Intersection example
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            printCollection(d); // Shows only the values that exist in both collections a and b.

            // Difference example
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            printCollection(e); // Shows the values that exist in a but not in b.
        }

        //  Method to print a collection with a generic type.
        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        
        }
    }
}
