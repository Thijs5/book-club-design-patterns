namespace DesignPattern.Builder.Solution.ConsoleApp.Models
{
    public class Spaceship
    {
        public string Designation { get; set; }
        public ShipType ShipType { get; set; }
        public int HitPoints { get; set; }
        public int NumberOfBlasters { get; set; } = 0;
        public int NumberOfMiningLasers { get; set; } = 0;
        public bool HasActiveCountermeasures { get; set; } = false;
    }
}
