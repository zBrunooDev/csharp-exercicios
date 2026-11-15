using System;

namespace Ex1197
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string line;

            while ((line = Console.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] valores = line.Split(' ');
                int v = int.Parse(valores[0]);
                int t = int.Parse(valores[1]);

                int displacement = v * t * 2;
                Console.WriteLine(displacement);
            }
        }
    }
}