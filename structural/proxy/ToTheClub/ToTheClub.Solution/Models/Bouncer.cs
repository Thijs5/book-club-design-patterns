using System;

namespace ToTheClub.Solution.Models
{
    public class Bouncer : IEntranceProvider
    {
        private const int MinimumRequiredAge = 18;
        private EntranceDoors _doors;

        public void HandleAccess(Person person)
        {
            if (person.Age >= MinimumRequiredAge)
            {
                _doors ??= new EntranceDoors();

                _doors.HandleAccess(person);
            }
            else
            {
                Console.WriteLine($"No access for person with age {person.Age}");
            }
        }
    }
}