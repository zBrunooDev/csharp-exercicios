using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1146
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if( n == 0 )
                {
                    break;
                }

                for ( int i = 1; i <= n; i++)
                { 
                    if (i == n)
                    {
                        sb.Append(i);
                    }
                    else
                    {
                        sb.Append(i).Append(" ");
                    }
                }
                sb.AppendLine();
            }
            Console.Write(sb.ToString());
        }
    }
}
