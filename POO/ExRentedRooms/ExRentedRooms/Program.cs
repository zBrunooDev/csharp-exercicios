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
            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            Students[] roomsRetend = new Students[10];

            for (int i = 0; i < rooms; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                roomsRetend[i] = new Students {Name = name, Email = email, Room = room};
                Console.WriteLine();
            }

            for(int i = 0;i < rooms; i++)
            {
                Console.WriteLine($"Busy rooms: ");
                Console.WriteLine($"{roomsRetend[i].Room}: {roomsRetend[i].Name}, {roomsRetend[i].Email}");

            }

        }
    }
}
