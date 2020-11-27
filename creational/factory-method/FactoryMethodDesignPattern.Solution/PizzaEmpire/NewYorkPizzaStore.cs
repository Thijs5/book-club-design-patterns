using FactoryMethodDesignPattern.Solution.PizzaEmpire.Models;

namespace FactoryMethodDesignPattern.Solution.PizzaEmpire
{
    // CONCRETE CREATOR
    public class NewYorkPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new NewYorkCheesePizza();
            }

            if (item.Equals("pepperoni"))
            {
                return new NewYorkPepperoniPizza();
            }

            return null;
        }
    }
}