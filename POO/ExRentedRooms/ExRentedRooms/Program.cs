using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExRentedRooms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Students[] roomsRetend = new Students[10];

            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= rooms; i++)
            {

                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                roomsRetend[room] = new Students(name, email);

            }

            Console.WriteLine();
            Console.WriteLine($"Busy rooms: ");
            for (int i = 0;i < 10; i++)
            {

                if(roomsRetend[i] != null)
                {
                    Console.WriteLine(i + ": " + roomsRetend[i]);
                }
            }

        }
    }
}
