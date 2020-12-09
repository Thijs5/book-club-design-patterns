using System;
using System.Collections.Generic;

namespace MakingBread.Exercise.Models
{
    public class WholeWheat : Bread
    {
        private readonly List<string> _ingredients = new List<string> { "yeast", "whole wheat flour", "salt", "butter" };

        public override void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }

        private void MixIngredients()
        {
            Console.WriteLine($"Gathering Ingredients for whole wheat bread: {string.Join(", ", _ingredients)}");
        }

        private void Bake()
        {
            Console.WriteLine("Baking the whole wheat bread. (15 minutes)");
        }

        private void Slice()
        {
            Console.WriteLine("Slicing the sourdough bread!");
        }
    }
}