using System;
using ToTheClub.Exercise.Models;

namespace ToTheClub.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubArt.DrawClub();

            var club = new Club(new EntranceDoors());
            club.GetVisitFrom(new Person {Age = 19});
            club.GetVisitFrom(new Person {Age = 13});
            club.GetVisitFrom(new Person {Age = 33});

            Console.ReadLine();
        }
    }
}
