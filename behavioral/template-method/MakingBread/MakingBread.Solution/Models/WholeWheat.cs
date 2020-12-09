using System;
using System.Collections.Generic;

namespace MakingBread.Solution.Models
{
    public class WholeWheat : Bread
    {
        private readonly List<string> _ingredients = new List<string> { "yeast", "whole wheat flour", "salt", "butter" };

        protected override void MixIngredients()
        {
            Console.WriteLine($"Gathering Ingredients for whole wheat bread: {string.Join(", ", _ingredients)}");
        }

        protected override void Bake()
        {
            Console.WriteLine("Baking the whole wheat bread. (15 minutes)");
        }
    }
}