using MakingBread.Exercise.Models;
using System;

namespace MakingBread.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BreadArt.PaintMeLikeOneOfYourFrenchGirls();

            var sourdough = new Sourdough();
            sourdough.Make();

            Console.WriteLine();

            var wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadLine();
        }
    }
}
