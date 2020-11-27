using FactoryMethodDesignPattern.Solution.PizzaEmpire.Models;

namespace FactoryMethodDesignPattern.Solution.PizzaEmpire
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }

            return pizza;
        }
    }
}