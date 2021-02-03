using DesignPattern.Builder.Solution.ConsoleApp.Builders;
using DesignPattern.Builder.Solution.ConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace DesignPattern.Builder.Solution.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteIntro();
            Console.ReadKey();
            var armada = GetArmada();

            PrintArmada(armada);
        }

        private static List<Spaceship> GetArmada()
        {
            var ships = new List<Spaceship>();

            var shipBuilder = new SpaceshipBuilder();
            var shipYard = new ShipYard(shipBuilder);
            shipYard.BuildStartedShip();
            ships.Add(shipBuilder.GetShip());

            shipYard.BuildAttackCruiser();
            ships.Add(shipBuilder.GetShip());

            shipYard.BuildBattleship();
            ships.Add(shipBuilder.GetShip());

            shipYard.BuildMiner();
            ships.Add(shipBuilder.GetShip());

            shipYard.BuildFriendShip();
            ships.Add(shipBuilder.GetShip());

            return ships;
        }

        private static void PrintArmada(List<Spaceship> armada)
        {
            foreach (var spaceship in armada)
            {
                Console.WriteLine($"Designation: {spaceship.Designation}");
                Console.WriteLine(new string('-', 13 + spaceship.Designation.Length));
                Console.WriteLine($"Type: {spaceship.ShipType}");
                Console.WriteLine($"HP: {spaceship.HitPoints} HP");
                Console.WriteLine($"Active counter measures: {spaceship.HasActiveCountermeasures}");
                Console.WriteLine($"Blaster count: {spaceship.NumberOfBlasters} Blasters");
                Console.WriteLine($"Mining laser count: {spaceship.NumberOfMiningLasers} mining lasers");
                Console.WriteLine();
            }
        }

        private static void WriteIntro()
        {
            Console.WriteLine(
                "                      `. ___\r\n                    __,' __`.                _..----....____\r\n        __...--.'``;.   ,.   ;``--..__     .'    ,-._    _.-'\r\n  _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'\r\n,'________________                          \\`-._`-','\r\n `._              ```````````------...___   '-.._'-:\r\n    ```--.._      ,.                     ````--...__\\-.\r\n            `.--. `-`                       ____    |  |`\r\n              `. `.                       ,'`````.  ;  ;`\r\n                `._`.        __________   `.      \\'__/`\r\n                   `-:._____/______/___/____`.     \\  `\r\n                               |       `._    `.    \\\r\n                               `._________`-.   `.   `.___\r\n                                             SSt  `------'`");
            Console.WriteLine();
            Console.WriteLine("Welcome earthling");
            Console.WriteLine("Fear my armada!");
            Console.WriteLine();
        }
    }
}
