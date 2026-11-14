using System;
namespace Ex1028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int f1 = int.Parse(valores[0]);
                int f2 = int.Parse(valores[1]);

                Console.WriteLine(CalcularMDC(f1, f2));
            }
        }

        static int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }
    }
}
