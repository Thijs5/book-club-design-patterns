namespace FactoryMethodDesignPattern.Solution.PizzaEmpire
{
    // CREATOR
    public abstract class PizzaStore
    {
        public abstract Models.Pizza CreatePizza(string item);

        public Models.Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}