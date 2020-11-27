using DesignPattern.ChainOfResponsibility.Kata.ConsoleApp.Helpers;
using DesignPattern.ChainOfResponsibility.Kata.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPattern.ChainOfResponsibility.Kata.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var firstInLine = new Son();
            firstInLine
                .SetNext(new Wife());

            GetSomeHelp(firstInLine);
        }

        private static void GetSomeHelp(IDadHelper helper)
        {
            var tasks = new List<(int complexity, string task)>
            {
                (3, "unloading the car"),
                (7, "painting the wall"),
                (5, "washing the car"),
                (99, "assembling this IKEA cabinet"),
                (15, "untangling my headphone cable")
            };

            foreach (var task in tasks)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Dad: I need some help {task.task}, who can help me?");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                var result = helper.Handle(task.complexity);
                Console.WriteLine(result ?? "Dad: Fine I'll do it myself!");
                Console.WriteLine();
                Console.ResetColor();
            }

        }
    }
}
