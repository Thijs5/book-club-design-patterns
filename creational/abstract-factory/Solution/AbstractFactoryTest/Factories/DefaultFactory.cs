using AbstractFactoryTest.Models;

namespace AbstractFactoryTest.Factories
{
    public class DefaultFactory
    {
        public virtual Chair MakeChair()
        {
            return new Chair();
        }

        public virtual Table MakeTable()
        {
            return new Table();
        }
    }
}
