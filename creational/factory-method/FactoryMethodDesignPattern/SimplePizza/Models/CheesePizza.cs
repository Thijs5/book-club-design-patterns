namespace FactoryMethodDesignPattern.SimplePizza.Models
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese";
            Sauce = "Tomato";
        }
    }
}