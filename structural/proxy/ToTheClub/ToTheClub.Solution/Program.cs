using System;
using ToTheClub.Solution.Models;

namespace ToTheClub.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubArt.DrawClub();

            var club = new Club(new Bouncer());
            club.GetVisitFrom(new Person {Age = 19});
            club.GetVisitFrom(new Person {Age = 13});
            club.GetVisitFrom(new Person {Age = 33});

            Console.ReadLine();
        }
    }
}
