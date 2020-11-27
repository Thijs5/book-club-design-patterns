using System;

namespace FactoryMethodDesignPattern.SimplePizza.Models
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Sauce { get; set; }

        public void Prepare()
        {
            Console.WriteLine("Preparing pizza: " + Name + " with sauce: " + Sauce);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza: " + Name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza: " + Name);
        }
    }
}