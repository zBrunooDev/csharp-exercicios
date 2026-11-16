using System;
using System.Linq;
using StudyLINQ.Entities;
using System.Collections.Generic;


namespace StudyLINQ
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };


            // ============================================================
            // 1. FILTERING AND PROJECTION
            // ============================================================

            // Where -> Filters a collection based on a predicate.
            // Returns only products that satisfy the specified condition.
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);


            // Select -> Projects each element into a new result.
            // In this example, returns only the names of products from Tools.
            var r2 = products
                .Where(p => p.Category.Name == "Tools")
                .Select(p => p.Name);

            Print("NAMES OF PRODUCTS FROM TOOLS", r2);


            // Select with an anonymous type -> Creates a new object
            // containing only the specified properties.
            // CategoryName is an alias for p.Category.Name.
            var r3 = products
                .Where(p => p.Name[0] == 'C')
                .Select(p => new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                });

            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);


            // ============================================================
            // 2. ORDERING AND PAGINATION
            // ============================================================

            // OrderBy -> Orders the collection in ascending order.
            // ThenBy -> Adds a secondary ordering criterion.
            // Multiple ordering criteria can be combined.
            var r4 = products
                .Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Name);

            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);


            // Skip -> Skips a specified number of elements.
            // Take -> Retrieves a specified number of elements.
            // Commonly used together for pagination.
            var r5 = r4.Skip(2).Take(4);

            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);


            // ============================================================
            // 3. ELEMENT OPERATORS
            // ============================================================

            // FirstOrDefault -> Returns the first element of a collection.
            // If the collection is empty, returns the default value.
            // For reference types, the default value is null.
            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);


            // FirstOrDefault can also be used after filtering.
            // Returns the first element that satisfies the condition.
            // If no element matches, returns the default value.
            var r7 = products
                .Where(p => p.Price > 3000.0)
                .FirstOrDefault();

            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();


            // SingleOrDefault -> Returns the only element of a collection.
            // If no element matches, returns the default value.
            // If more than one element matches, throws an exception.
            var r8 = products
                .Where(p => p.Id == 3)
                .SingleOrDefault();

            Console.WriteLine("Single or default test1: " + r8);


            // No element matches the specified condition.
            // Therefore, SingleOrDefault returns null.
            var r9 = products
                .Where(p => p.Id == 30)
                .SingleOrDefault();

            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();


            // ============================================================
            // 4. AGGREGATION OPERATORS
            // ============================================================

            // Max -> Returns the highest value in a collection.
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);


            // Min -> Returns the lowest value in a collection.
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);


            // Sum -> Returns the sum of all selected values.
            // An empty numeric collection returns zero.
            var r12 = products
                .Where(p => p.Category.Id == 1)
                .Sum(p => p.Price);

            Console.WriteLine("Category 1 Sum prices: " + r12);


            // Average -> Calculates the average of the selected values.
            // An empty collection causes an InvalidOperationException.
            var r13 = products
                .Where(p => p.Category.Id == 1)
                .Average(p => p.Price);

            Console.WriteLine("Category 1 Average prices: " + r13);


            // DefaultIfEmpty -> Provides a default element if the collection is empty.
            // Here, 0.0 is used to prevent Average from receiving an empty collection.
            var r14 = products
                .Where(p => p.Category.Id == 5)
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average();

            Console.WriteLine("Category 5 Average prices: " + r14);


            // Aggregate -> Applies an accumulation function to the collection.
            // The first argument (0.0) is the initial value.
            // The lambda receives the accumulated value (x)
            // and the current element (y), returning their sum.
            var r15 = products
                .Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate(0.0, (x, y) => x + y);

            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();


            // ============================================================
            // 5. GROUPING OPERATORS
            // ============================================================

            // GroupBy -> Groups collection elements according to a key.
            // Each group contains:
            // - Key: the value used to identify the group.
            // - Elements: the collection elements belonging to that group.
            //
            // Here, products are grouped by their Category.
            var r16 = products.GroupBy(p => p.Category);

            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");

                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine();
            }

        }
    }
}
