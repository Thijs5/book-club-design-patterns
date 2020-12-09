namespace DesignPattern.Memento.Kata.BlazorApp.Domain
{
    public interface IMemento
    {
        string GetName();
        Tile[] GetTiles();
        string GetTheme();
    }

    internal class MapLayoutMemento : IMemento
    {
        private readonly string _name;
        private readonly Tile[] _tiles;
        private readonly string _theme;

        public MapLayoutMemento(string name, Tile[] tiles, string theme)
        {
            _name = name;
            _tiles = tiles;
            _theme = theme;
        }

        public string GetName()
        {
            return _name;
        }

        public Tile[] GetTiles()
        {
            return _tiles;
        }

        public string GetTheme()
        {
            return _theme;
        }
    }
}