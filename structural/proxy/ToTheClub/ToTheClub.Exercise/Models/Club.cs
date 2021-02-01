namespace ToTheClub.Exercise.Models
{
    public class Club
    {
        private readonly EntranceDoors _entranceDoors;

        public Club(EntranceDoors entranceDoors)
        {
            _entranceDoors = entranceDoors;
        }

        public void GetVisitFrom(Person person)
        {
            _entranceDoors.HandleAccess(person);
        }
    }
}