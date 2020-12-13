using DesignPattern.Memento.Kata.BlazorApp.Domain;
using System.Collections.Generic;

namespace DesignPattern.Memento.Kata.BlazorApp.Core
{
    public class MapCaretaker
    {
        private readonly Dictionary<string, IMemento> _mementos = new Dictionary<string, IMemento>();
        private readonly MapLayout _mapLayout;

        public MapCaretaker(MapLayout mapLayout)
        {
            _mapLayout = mapLayout;
        }

        public void Backup()
        {
            var memento = _mapLayout.GetSnapshot();
            _mementos.Add(memento.GetName(), memento);
        }

        public void Restore(string snapshotName)
        {
            var snapshot = _mementos[snapshotName];
            _mapLayout.RestoreSnapshot(snapshot);
        }

        public IEnumerable<string> GetHistory()
        {
            return _mementos.Keys;
        }
    }
}
