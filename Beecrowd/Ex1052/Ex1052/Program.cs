using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ex1052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine(meses[mes - 1]);
        }
    }
}