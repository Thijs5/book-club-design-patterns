namespace DesignPattern.Memento.Kata.BlazorApp.Domain
{
    public class Tile
    {
        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; }
        public int Y { get; }
        public string Asset { get; set; }
    }
}
