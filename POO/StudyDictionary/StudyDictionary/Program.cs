using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A structure that stores key-value pairs: Dictionary<TKey, TValue>.
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // Creating a key and assigning it a value.
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133"; // The key "phone" is assigned the specified value.

            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            Console.WriteLine("Phone number: " + cookies["phone"]);

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");

            // Iterating through a Dictionary collection using foreach.
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
