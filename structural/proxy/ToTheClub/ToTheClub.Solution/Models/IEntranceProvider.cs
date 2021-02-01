namespace ToTheClub.Solution.Models
{
    public interface IEntranceProvider
    {
        public void HandleAccess(Person person);
    }
}