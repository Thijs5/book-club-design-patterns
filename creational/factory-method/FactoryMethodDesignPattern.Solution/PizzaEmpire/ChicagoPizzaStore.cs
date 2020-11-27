using FactoryMethodDesignPattern.Solution.PizzaEmpire.Models;

namespace FactoryMethodDesignPattern.Solution.PizzaEmpire
{
    // CONCRETE CREATOR
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoCheesePizza();
            }

            if (item.Equals("pepperoni"))
            {
                return new ChicagoPepperoniPizza();
            }

            return null;
        }
    }
}