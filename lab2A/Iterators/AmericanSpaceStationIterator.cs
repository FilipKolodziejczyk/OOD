using System.Collections;
using SpaceStation.Stations;

namespace SpaceStation.Iterators
{
    public class AmericanSpaceStationIterator : IEnumerator
    {
        private AmericanSpaceStation _station;
        private int _currentPos;
        private int _current => _station.Planets[_currentPos].Item2;

        public AmericanSpaceStationIterator(AmericanSpaceStation station)
        {
            _station = station;
            _currentPos = -1;
        }

        public object Current => _current;

        public bool MoveNext()
        {
            _currentPos++;
            return (_currentPos < _station.Planets.Length);
        }

        public void Reset()
        {
            _currentPos = -1;
        }
    }
}
