using AbstractFactoryTest.Models;

namespace AbstractFactoryTest.Factories
{
    public class GhettoFactory : DefaultFactory
    {
        override public Chair MakeChair()
        {
            return new FancyChair();
        }

        override public Table MakeTable()
        {
            return new BudgetTable();
        }
    }
}
