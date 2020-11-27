using DesignPattern.ChainOfResponsibility.Kata.ConsoleApp.Interfaces;

namespace DesignPattern.ChainOfResponsibility.Kata.ConsoleApp.Helpers
{
    public class Wife : IDadHelper
    {
        private IDadHelper _nextHandler;
        public IDadHelper SetNext(IDadHelper handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public string Handle(int complexity)
        {
            if (complexity <= 10)
            {
                return "Wife: Let me help you dear.";
            }
            return _nextHandler?.Handle(complexity);
        }
    }
}
