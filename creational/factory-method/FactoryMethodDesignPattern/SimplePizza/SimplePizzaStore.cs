using FactoryMethodDesignPattern.SimplePizza.Models;

namespace FactoryMethodDesignPattern.SimplePizza
{
    public class NewYorkPizzaFactory : SimplePizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "New York Cheese Pizza")
            {
                return new NewYorkCheesePizza();
            }

            return base.CreatePizza(type);
        }
    }

    public class NewYorkPizzaStore : SimplePizzaStore
    {
        public NewYorkPizzaStore() : base(new NewYorkPizzaFactory())
        {
        }
    }
    public abstract class SimplePizzaStore
    {
        private SimplePizzaFactory _factory;

        protected SimplePizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            var pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}