using DesignPattern.ChainOfResponsibility.Kata.ConsoleApp.Interfaces;

namespace DesignPattern.ChainOfResponsibility.Kata.ConsoleApp.Helpers
{
    public class Son : IDadHelper
    {
        private IDadHelper _nextHandler;
        public IDadHelper SetNext(IDadHelper handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public string Handle(int complexity)
        {
            if (complexity <= 5)
            {
                return "Son: I'll help you daddy!";
            }
            return _nextHandler?.Handle(complexity);
        }
    }
}
