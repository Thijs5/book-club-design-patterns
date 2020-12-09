using MakingBread.Solution.Models;
using System;

namespace MakingBread.Solution
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
