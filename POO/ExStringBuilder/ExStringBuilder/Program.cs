using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice tripe");
            Comment c2 = new Comment("Wow that's awesome!");

            Post post = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going  to visit this wonderful country!",
                12
            );

            post.AddCommnt(c1);
            post.AddCommnt(c2);

            Console.WriteLine(post);
        }
    }
}
