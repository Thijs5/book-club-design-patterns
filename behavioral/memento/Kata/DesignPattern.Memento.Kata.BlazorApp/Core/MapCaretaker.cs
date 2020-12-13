using DesignPattern.Memento.Kata.BlazorApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

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
            // _mapLayout.GetSnapshot();
            // append to list of snapshots
        }

        public void Restore(string snapshotName)
        {

            // var snapshot = _mementos[snapshotName];
            // _mapLayout.RestoreSnapshot(snapshot);
        }

        public IEnumerable<string> GetHistory()
        {
            // return _mementos.Keys;
            return Enumerable.Range(0, 20).Select(x => $"{x:00} - {DateTime.Now}").OrderBy(x => x).Take(15);
        }
    }
}
