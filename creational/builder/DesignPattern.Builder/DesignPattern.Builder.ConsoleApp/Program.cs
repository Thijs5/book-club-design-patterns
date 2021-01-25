using DesignPattern.Builder.ConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace DesignPattern.Builder.ConsoleApp
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
            var starterShip = new Spaceship("Nooby", ShipType.Basic, 100);
            var attackCruiser = new Spaceship("Cobra", ShipType.Assault, 500, 8);
            var battleShip = new Spaceship("Tankzilla", ShipType.Defense, 1200, 6, 0, true);
            var miner = new Spaceship("John Deere", ShipType.Miner, 700, 0, 5, false);
            var friendShip = new Spaceship("FriendShip", ShipType.Support, 1, 0, 0, false);

            ships.Add(starterShip);
            ships.Add(attackCruiser);
            ships.Add(battleShip);
            ships.Add(miner);
            ships.Add(friendShip);
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
