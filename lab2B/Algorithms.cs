using System;
using System.Collections;
using System.Collections.Generic;
using Vectors.Vectors;

namespace Vectors
{
    public static class Algorithms
    {
        public static double Norm(IEnumerator enumerator)
        {
            double result = 0;
            while (enumerator.MoveNext())
                result += Math.Pow((int)enumerator.Current, 2);
            return Math.Sqrt(result);
        }

        public static ArrayVector Concatenate(IEnumerator enumerator1, IEnumerator enumerator2)
        {
            List<int> vector = new List<int>();
            while (enumerator1.MoveNext())
                vector.Add((int)enumerator1.Current);
            while (enumerator2.MoveNext())
                vector.Add((int)enumerator2.Current);
            return new ArrayVector(vector.ToArray());
        }

        public static void PrintVector(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
                Console.Write("{0} ", enumerator.Current);
            Console.WriteLine();
        }
    }
}
