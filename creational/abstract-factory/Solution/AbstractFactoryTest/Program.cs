using AbstractFactoryTest.Factories;
using AbstractFactoryTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Shopper!");
            Console.WriteLine("We have the following table sets in stock:");
            var sets = GetTableSets();
            foreach (var set in sets)
            {
                Console.WriteLine($"This set has a {set.Table} with {set.Chairs.Count} {set.Chairs.First()}s");
            }

            Console.ReadLine();
        }

        private static List<DiningSet> GetTableSets()
        {
            List<DiningSet> sets = new List<DiningSet>();
            sets.Add(AssembleSet(new DefaultFactory()));
            sets.Add(AssembleSet(new FancyFactory()));
            sets.Add(AssembleSet(new GhettoFactory()));
            return sets;
        }

        private static DiningSet AssembleSet(DefaultFactory factory)
        {
            List<Chair> chairs = new List<Chair>();

            for (int i = 0; i < 4; i++)
            {
                chairs.Add(factory.MakeChair());
            }

            return new DiningSet()
            {
                Table = factory.MakeTable(),
                Chairs = chairs
            };
        }
    }
}
