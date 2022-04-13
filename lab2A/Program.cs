using System.Collections.Generic;
using System.Diagnostics;
using SpaceStation.Stations;

namespace SpaceStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var americanStation = new AmericanSpaceStation(new[]
            {
                (Planet.Mercury, 1250),
                (Planet.Venus, 1005),
                (Planet.Earth, 800),
                (Planet.Mars, 700),
                (Planet.Jupiter, 900),
                (Planet.Saturn, 1050),
                (Planet.Uranus, 1100),
                (Planet.Neptune, 1200)
            });

            var chineseStation = PrepareChineseSpaceStation(new[]
            {
                (Planet.Venus, 500),
                (Planet.Earth, 400),
                (Planet.Mars, 700),
                (Planet.Jupiter, 800),
                (Planet.Uranus, 950),
            });

            var ints = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Debug.Assert(Algorithms.MinMaxDistances(americanStation.GetEnumerator()) == (700, 1250), "Wrong value - assert 1"); // americanStation
            Debug.Assert(Algorithms.MinMaxDistances(chineseStation.GetEnumerator()) == (400, 950), "Wrong value - assert 2"); // chineseStation
            
            Debug.Assert(Algorithms.MinMaxDistances(Algorithms.EveryThirdSum(americanStation.GetEnumerator()).GetEnumerator()) == (1850, 3105), "Wrong value - assert 3"); // americanStation
            Debug.Assert(Algorithms.MinMaxDistances(Algorithms.EveryThirdSum(chineseStation.GetEnumerator()).GetEnumerator()) == (700, 1350), "Wrong value - assert 4"); // chineseStation
        }

        private static ChineseSpaceStation PrepareChineseSpaceStation((Planet, int)[] planets)
        {
            Node root = null;
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                var node = new Node(root, planets[i].Item1, planets[i].Item2);
                root = node;
            }

            return new ChineseSpaceStation(root);
        }
    }
}
