using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ExerciceMediaProducts.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }

        public Product (string name, Double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price}";
        }
    }
}
