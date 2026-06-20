using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1020
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int N = int.Parse(Console.ReadLine());

                int  anos, meses, dias, resto;

                anos = N / 365;
                resto = N % 365;
                meses = resto / 30;
                resto = resto % 30;
                dias = resto;

                Console.WriteLine($"{anos} ano(s)");
                Console.WriteLine($"{meses} mes(es)");
                Console.WriteLine($"{dias} dia(s)");

            

        }
    }
    
}
