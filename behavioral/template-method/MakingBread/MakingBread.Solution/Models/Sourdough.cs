using System;
using System.Collections.Generic;

namespace MakingBread.Solution.Models
{
    public class Sourdough : Bread
    {
        private readonly List<string> _ingredients = new List<string> { "sourdough starter", "flour", "salt" };

        protected override void MixIngredients()
        {
            Console.WriteLine($"Gathering Ingredients for sourdough bread: {string.Join(", ", _ingredients)}.");
        }

        protected override void Bake()
        {
            Console.WriteLine("Baking the sourdough bread. (20 minutes)");
        }

        protected override void FinishOff()
        {
            Console.WriteLine("Sprinkle some flour all over the bread. Mmm.");
        }
    }
}