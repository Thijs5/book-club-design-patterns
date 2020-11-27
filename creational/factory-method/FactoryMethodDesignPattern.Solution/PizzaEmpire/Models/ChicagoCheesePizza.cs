namespace FactoryMethodDesignPattern.Solution.PizzaEmpire.Models
{
    // CONCRETE PRODUCT
    public class ChicagoCheesePizza : CheesePizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Cheese";
            Sauce = "Chicago style";
        }
    }
}