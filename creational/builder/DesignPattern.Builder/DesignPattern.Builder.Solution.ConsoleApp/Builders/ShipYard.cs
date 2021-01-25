using DesignPattern.Builder.Solution.ConsoleApp.Models;

namespace DesignPattern.Builder.Solution.ConsoleApp.Builders
{
    public class ShipYard
    {
        private readonly SpaceshipBuilder _spaceshipBuilder;

        public ShipYard(SpaceshipBuilder spaceshipBuilder)
        {
            _spaceshipBuilder = spaceshipBuilder;
        }

        public void BuildStartedShip()
        {
            _spaceshipBuilder.SetDesignation("Nooby");
            _spaceshipBuilder.SetShipType(ShipType.Basic);
            _spaceshipBuilder.SetHitPoints(100);
        }

        public void BuildAttackCruiser()
        {
            _spaceshipBuilder.SetDesignation("Cobra");
            _spaceshipBuilder.SetShipType(ShipType.Assault);
            _spaceshipBuilder.SetHitPoints(500);
            _spaceshipBuilder.SetNumberOfBlasters(8);
        }

        public void BuildBattleship()
        {
            _spaceshipBuilder.SetDesignation("Tankzilla");
            _spaceshipBuilder.SetShipType(ShipType.Defense);
            _spaceshipBuilder.SetHitPoints(1200);
            _spaceshipBuilder.SetNumberOfBlasters(5);
            _spaceshipBuilder.SetActiveCountermeasures(true);
        }

        public void BuildMiner()
        {
            _spaceshipBuilder.SetDesignation("John Deere");
            _spaceshipBuilder.SetShipType(ShipType.Miner);
            _spaceshipBuilder.SetHitPoints(700);
            _spaceshipBuilder.SetNumberOfMiningLasers(5);
        }

        public void BuildFriendShip()
        {
            _spaceshipBuilder.SetDesignation("FriendShip");
            _spaceshipBuilder.SetShipType(ShipType.Support);
            _spaceshipBuilder.SetHitPoints(1);
        }
    }
}
