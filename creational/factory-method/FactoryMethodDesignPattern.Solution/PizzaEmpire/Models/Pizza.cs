using System;

namespace FactoryMethodDesignPattern.Solution.PizzaEmpire.Models
{
    // PRODUCT
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Sauce { get; set; }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name + " with sauce: " + Sauce);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + Name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing " + Name);
        }
    }
}