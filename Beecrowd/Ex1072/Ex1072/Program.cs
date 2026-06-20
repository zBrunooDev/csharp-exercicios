using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1072
{
    class Program
    {
        static void Main(string[] args)
        {

            int contagemDentro = 0 , contagemFora = 0;
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++ )
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contagemDentro++;
                }
                if(x < 10 || x > 20)
                {
                    contagemFora++; 
                }
            }

            Console.WriteLine($"{contagemDentro} in");
            Console.WriteLine($"{contagemFora} out");

        }
    }
}
