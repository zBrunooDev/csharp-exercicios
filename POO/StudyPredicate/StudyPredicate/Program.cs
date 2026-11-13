using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudyPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // RemoveAll expects a Predicate<Product> as its parameter signature
            /*list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            */
            Console.WriteLine("-----------------------------------");

            // Action Example with ForEach

            list.ForEach(p => { p.Price += p.Price * 0.1; }); // Predicate with lambda in Line

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-----------------------------------");

            // Func Example with Select

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();
            foreach(string p in result)
            {
                Console.WriteLine(p);
            }

        }
        // Predicate signature: receives an object (Product) and returns a bool
        static bool ProductTest(Product product)
        {
            return product.Price > 100;
        }

    }
}
