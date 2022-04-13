using System.Collections;
using SpaceStation.Stations;

namespace SpaceStation.Iterators
{
    public class ChineseSpaceStationIterator : IEnumerator
    {
        private ChineseSpaceStation _station;
        private Node _current = null;
        private bool _inInitialState;

        public ChineseSpaceStationIterator(ChineseSpaceStation spaceStation)
        {
            _station = spaceStation;
            _inInitialState = true;
        }
        
        public object Current => _current.Distance;

        public bool MoveNext()
        {
            if (_inInitialState)
            {
                _current = _station.Root;
                _inInitialState = false;
            }
            else
                _current = _current.Next;
            return (_current != null);  
        }

        public void Reset()
        {
            _current = null;
            _inInitialState = true;
        }
    }
}
