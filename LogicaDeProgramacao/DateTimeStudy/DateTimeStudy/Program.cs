
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = new DateTime(2026, 8, 24, 18, 0, 0);

            Console.WriteLine(inicio.ToString());

            DateTime sumHours = inicio.AddHours(02);

            Console.WriteLine(sumHours.ToString());

            DateTime sumMinutes = inicio.AddMinutes(30);

            Console.WriteLine(sumMinutes.ToString());

            Console.WriteLine(inicio.DayOfWeek);

            Console.WriteLine(sumHours.Hour);


        }
    }
}
