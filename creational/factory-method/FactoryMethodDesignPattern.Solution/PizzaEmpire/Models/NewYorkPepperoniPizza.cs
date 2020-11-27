namespace FactoryMethodDesignPattern.Solution.PizzaEmpire.Models
{
    // CONCRETE PRODUCT
    public class NewYorkPepperoniPizza : PepperoniPizza
    {
        public NewYorkPepperoniPizza()
        {
            Name = "New York Pepperoni";
            Sauce = "New York style";
        }
    }
}