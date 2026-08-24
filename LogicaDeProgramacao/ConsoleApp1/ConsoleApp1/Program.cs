using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Verificar os métodos com a String de acordo com a aula do curso.

            string name = "  Bruno Lima - CSharp  ";

            string vazia = "";

            Console.WriteLine(name);

            Console.WriteLine("-------------------");

            Console.WriteLine(name.Trim());

            Console.WriteLine("-------------------");

            Console.WriteLine(name.ToUpper());

            Console.WriteLine("-------------------");

            Console.WriteLine(name.ToLower());

            Console.WriteLine("-------------------");

            Console.WriteLine(name.IndexOf("Lima"));

            Console.WriteLine("-------------------");

            Console.WriteLine(name.Substring(2, 6));

            Console.WriteLine("-------------------");

            Console.WriteLine(name.Replace("CSharp", "C#"));

            Console.WriteLine("-------------------");

            Console.WriteLine(string.IsNullOrEmpty(vazia));

            Console.WriteLine("-------------------");

        }
    }
}
