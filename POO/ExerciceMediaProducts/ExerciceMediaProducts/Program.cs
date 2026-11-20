using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ExerciceMediaProducts.Entities;

namespace ExerciceMediaProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = @"C:\Users\zbrun\OneDrive\Documentos\ExeciceFiles\Products.txt";

            List<Product> products = new List<Product>();
            
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    products.Add(new Product(name, price));
                }
            }

            var avg = products.Select(p => p.Price).DefaultIfEmpty().Average();
            var names = products.Where(p => p.Price <  avg).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();

            Console.WriteLine("Avarage price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }   


    }
}
