using System.Collections;
using Vectors.Iterators;

namespace Vectors.Vectors
{
    public class ArrayVector
    {
        public int[] Vector { get; }

        public ArrayVector(int[] vector)
        {
            Vector = vector;
        }

        public IEnumerator GetEnumerator()
        {
            return new ArrayVectorIterator(this);
        }

        public IEnumerator GetReverseEnumerator()
        {
            return new ReverseArrayVectorIterator(this);
        }
    }
}
