using DesignPattern.Memento.Kata.BlazorApp.Domain;
using System;

namespace DesignPattern.Memento.Kata.BlazorApp.Core
{
    public class MapLayout // Originator
    {
        public Tile[] Tiles;
        public string Theme;

        public MapLayout(Tile[] tiles, string theme)
        {
            Tiles = tiles;
            Theme = theme;
        }

        public IMemento GetSnapshot()
        {
            return new MapLayoutMemento(DateTime.Now.Ticks.ToString(), Tiles, Theme);
        }

        public void RestoreSnapshot(IMemento snapshot)
        {
            Tiles = snapshot.GetTiles();
            Theme = snapshot.GetTheme();
        }
    }
}
