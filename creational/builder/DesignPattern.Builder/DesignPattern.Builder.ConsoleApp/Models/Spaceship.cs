namespace DesignPattern.Builder.ConsoleApp.Models
{
    public class Spaceship
    {
        public string Designation { get; set; }
        public ShipType ShipType { get; set; }
        public int HitPoints { get; set; }
        public int NumberOfBlasters { get; set; }
        public int NumberOfMiningLasers { get; set; }
        public bool HasActiveCountermeasures { get; set; }

        public Spaceship(
            string designation,
            ShipType shipType,
            int hitPoints,
            int numberOfBlasters = 0,
            int numberOfMiningLasers = 0,
            bool hasActiveCountermeasures = false)
        {
            Designation = designation;
            ShipType = shipType;
            HitPoints = hitPoints;
            NumberOfBlasters = numberOfBlasters;
            NumberOfMiningLasers = numberOfMiningLasers;
            HasActiveCountermeasures = hasActiveCountermeasures;
        }
    }
}
