namespace FactoryMethodDesignPattern.SimplePizza.Models
{
    public class NewYorkCheesePizza : CheesePizza
    {
        public NewYorkCheesePizza()
        {
            Name = "New York Cheese Pizza";
            Sauce = "Tears of the poor";
        }
    }
}