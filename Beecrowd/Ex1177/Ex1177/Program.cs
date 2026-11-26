using System;

namespace Ex1177
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] N = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                N[i] = i % T;
                Console.WriteLine($"N[{i}] = {N[i]}");
            }
        }
    }
}
