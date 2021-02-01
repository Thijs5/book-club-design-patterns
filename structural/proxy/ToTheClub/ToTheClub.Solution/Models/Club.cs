namespace ToTheClub.Solution.Models
{
    public class Club
    {
        private readonly IEntranceProvider _entranceProvider;

        public Club(IEntranceProvider entranceProvider)
        {
            _entranceProvider = entranceProvider;
        }

        public void GetVisitFrom(Person person)
        {
            _entranceProvider.HandleAccess(person);
        }
    }
}