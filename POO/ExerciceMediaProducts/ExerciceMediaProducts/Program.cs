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
            string filePath = @"C:\Users\zbrun\OneDrive\Documentos\ExeciceFiles\Products.txt";

            List<Product> products = new List<Product>();
            
            using(StreamReader reader = File.OpenText(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    products.Add(new Product(name, price));
                }
            }

            var avaragePrice = products.Select(p => p.Price).DefaultIfEmpty().Average();
            var productsBelowAverage = products.Where(p => p.Price < avaragePrice).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();

            Console.WriteLine("Avarage price: " + avaragePrice.ToString("F2", CultureInfo.InvariantCulture));

            foreach(string name in productsBelowAverage)
            {
                Console.WriteLine(name);
            }
        }   


    }
}
