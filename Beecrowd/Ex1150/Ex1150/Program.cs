using System;
namespace Ex1150
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            while(z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int quantity = 0;

            while(sum <= z)
            {
                sum += x + quantity;
                quantity++;
            }

            Console.WriteLine(quantity);
        }
    }
}
