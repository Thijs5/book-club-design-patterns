namespace FactoryMethodDesignPattern.Solution.PizzaEmpire.Models
{
    // CONCRETE PRODUCT
    public class NewYorkCheesePizza : CheesePizza
    {
        public NewYorkCheesePizza()
        {
            Name = "New York Cheese";
            Sauce = "New York style";
        }
    }
}