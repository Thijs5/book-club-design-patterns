using FactoryMethodDesignPattern.SimplePizza.Models;

namespace FactoryMethodDesignPattern.SimplePizza
{
    public class SimplePizzaFactory
    {
        public virtual Pizza CreatePizza(string type)
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