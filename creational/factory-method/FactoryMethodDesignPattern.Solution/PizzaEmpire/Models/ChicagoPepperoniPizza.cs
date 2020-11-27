namespace FactoryMethodDesignPattern.Solution.PizzaEmpire.Models
{
    // CONCRETE PRODUCT
    public class ChicagoPepperoniPizza : PepperoniPizza
    {
        public ChicagoPepperoniPizza()
        {
            Name = "Chicago Pepperoni";
            Sauce = "Chicago style";
        }
    }
}