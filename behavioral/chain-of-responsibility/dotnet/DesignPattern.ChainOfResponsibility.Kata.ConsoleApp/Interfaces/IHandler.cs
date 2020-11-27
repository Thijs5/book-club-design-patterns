namespace DesignPattern.ChainOfResponsibility.Kata.ConsoleApp.Interfaces
{
    public interface IDadHelper
    {
        IDadHelper SetNext(IDadHelper handler);

        string Handle(int complexity);
    }
}