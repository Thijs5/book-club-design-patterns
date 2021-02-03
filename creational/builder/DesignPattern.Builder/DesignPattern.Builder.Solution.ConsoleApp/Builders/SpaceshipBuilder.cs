using DesignPattern.Builder.Solution.ConsoleApp.Models;

namespace DesignPattern.Builder.Solution.ConsoleApp.Builders
{
    public class SpaceshipBuilder
    {
        private Spaceship _spaceship;

        public SpaceshipBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _spaceship = new Spaceship();
        }

        public void SetDesignation(string designation)
        {
            _spaceship.Designation = designation;
        }
        public void SetShipType(ShipType shipType)
        {
            _spaceship.ShipType = shipType;
        }
        public void SetHitPoints(int hitPoints)
        {
            _spaceship.HitPoints = hitPoints;
        }
        public void SetNumberOfBlasters(int numberOfBlasters)
        {
            _spaceship.NumberOfBlasters = numberOfBlasters;
        }
        public void SetNumberOfMiningLasers(int numberOfMiningLasers)
        {
            _spaceship.NumberOfMiningLasers = numberOfMiningLasers;
        }
        public void SetActiveCountermeasures(bool hasActiveCountermeasures)
        {
            _spaceship.HasActiveCountermeasures = hasActiveCountermeasures;
        }

        public Spaceship GetShip()
        {
            var result = _spaceship;
            Reset();
            return result;
        }
    }
}
