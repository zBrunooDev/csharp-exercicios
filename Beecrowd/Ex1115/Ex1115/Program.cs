using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1115
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;
            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while(x != 0 && y != 0 )
            {

                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                if(x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

        }
    }
}
