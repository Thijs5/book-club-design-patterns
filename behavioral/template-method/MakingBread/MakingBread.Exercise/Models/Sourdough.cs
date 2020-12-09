using System;
using System.Collections.Generic;

namespace MakingBread.Exercise.Models
{
    public class Sourdough : Bread
    {
        private readonly List<string> _ingredients = new List<string> { "sourdough starter", "flour", "salt" };

        public override void Make()
        {
            MixIngredients();
            Bake();
            FinishOff();
            Slice();
        }

        private void MixIngredients()
        {
            Console.WriteLine($"Gathering Ingredients for sourdough bread: {string.Join(", ", _ingredients)}.");
        }

        private void Bake()
        {
            Console.WriteLine("Baking the sourdough bread. (20 minutes)");
        }

        private void FinishOff()
        {
            Console.WriteLine("Sprinkle some flour all over the bread. Mmm.");
        }

        private void Slice()
        {
            Console.WriteLine("Slicing the sourdough bread!");
        }
    }
}