using System;
using System.Collections;

namespace SpaceStation
{
    public static class Algorithms
    {
        public static (int, int) MinMaxDistances(IEnumerator iterator)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            while (iterator.MoveNext())
            {
                int current = (int)iterator.Current;

                if (current < min)
                    min = current;

                if (current > max)
                    max = current;
            }

            return (min, max);
        }

        public static int[] EveryThirdSum(IEnumerator iterator)
        {
            int[] sum = new int[3];
            if (!iterator.MoveNext())
                return sum;

            do
                sum[0] += (int)iterator.Current;
            while (MoveK(iterator, 3));
            iterator.Reset();

            if (!MoveK(iterator, 2))
                return sum;
            do
                sum[1] += (int)iterator.Current;
            while (MoveK(iterator, 3));
            iterator.Reset();

            if (!MoveK(iterator, 3))
                return sum;
            do
                sum[2] += (int)iterator.Current;
            while (MoveK(iterator, 3));

            return sum;
        }

        public static bool MoveK(IEnumerator iterator, int k)
        {
            for (int i = 0; i < k; i++)
                if (!iterator.MoveNext())
                    return false;
            return true;
        }
    }
}
