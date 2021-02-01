using System;

namespace ToTheClub.Solution.Models
{
    public class EntranceDoors : IEntranceProvider
    {
        public void HandleAccess(Person person)
        {
            Console.WriteLine($"Granting access to person with age {person.Age}");
        }
    }
}