using StringBuilderProj.Entities;
using System;

namespace StringBuilderProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow, thats is awesome!");
            Post p1 = new Post(
                DateTime.Parse("07/08/2019 13:05:44"),
                "Traveling to New Zealand.",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("07/27/2019 16:34:33"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
        }
    }
}
