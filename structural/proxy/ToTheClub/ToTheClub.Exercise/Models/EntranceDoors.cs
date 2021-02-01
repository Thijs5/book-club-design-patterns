using System;

namespace ToTheClub.Exercise.Models
{
    public class EntranceDoors
    {
        public void HandleAccess(Person person)
        {
            Console.WriteLine($"Granting access to person with age {person.Age}");
        }
    }
}