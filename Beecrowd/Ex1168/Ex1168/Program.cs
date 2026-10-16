using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1168
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            
            int[] leds = new int[] { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };

            for(int i = 0; i < n; i++)
            {
                int count = 0;
                string value = Console.ReadLine();
                for(int j = 0; j < value.Length; j++)
                {
                    for (int k = 0; k < leds.Length; k++)
                    {
                        if((int)value[j] == k)
                        {
                            count += leds[k];
                        }
                      
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
