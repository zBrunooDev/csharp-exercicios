using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());

            // I needed to finish the other classes to continue implementing them in Program.

        }
    }
}
