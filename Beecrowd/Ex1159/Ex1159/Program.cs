using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
           
            do
            {
                int soma = 0, cont = 0;
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                    break;

                do 
                {

                    if (n % 2 == 0)
                    {
                        soma += n;
                        cont++;
                    }
                    n++;
                }
                while (cont < 5);

                Console.WriteLine(soma);

            } while (true);

            
        }
    }
}
