using DesignPattern.Memento.Kata.BlazorApp.Domain;
using System;

namespace DesignPattern.Memento.Kata.BlazorApp.Core
{
    public class MapLayout // Originator
    {
        public readonly Tile[] Tiles;
        public string Theme;

        public MapLayout(Tile[] tiles, string theme)
        {
            Tiles = tiles;
            Theme = theme;
        }

        public IMemento GetSnapshot()
        {
            throw new NotImplementedException();
        }

        public void RestoreSnapshot(IMemento snapshot)
        {
            throw new NotImplementedException();
        }
    }
}
