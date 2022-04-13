using System.Collections;
using SpaceStation.Iterators;

namespace SpaceStation.Stations
{
    public class AmericanSpaceStation : IEnumerable
    {
        public (Planet, int)[] Planets { get; }

        public AmericanSpaceStation((Planet, int)[] planets)
        {
            Planets = planets;
        }

        public IEnumerator GetEnumerator()
        {
            return new AmericanSpaceStationIterator(this);
        }
    }
}
