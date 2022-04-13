using System.Collections;
using SpaceStation.Iterators;

namespace SpaceStation.Stations
{
    public class ChineseSpaceStation : IEnumerable
    {
        public Node Root { get; }

        public ChineseSpaceStation(Node root)
        {
            Root = root;
        }

        public IEnumerator GetEnumerator()
        {
            return new ChineseSpaceStationIterator(this);
        }
    }

    public class Node
    {
        public Node Next { get; }

        public Planet Planet { get; }

        public int Distance { get; }

        public Node(Node next, Planet planet, int distance)
        {
            Next = next;
            Planet = planet;
            Distance = distance;
        }
    }
}
