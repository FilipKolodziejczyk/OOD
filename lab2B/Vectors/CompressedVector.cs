using System.Collections;
using Vectors.Iterators;

namespace Vectors.Vectors
{
    public class CompressedVector
    {
        public (int, int)[] Vector { get; set; }

        public CompressedVector((int, int)[] vector)
        {
            Vector = vector;
        }
        
        public IEnumerator GetEnumerator()
        {
            return new CompressedVectorIterator(this);
        }

        public IEnumerator GetReverseEnumerator()
        {
            return new ReverseCompressedVectorIterator(this);
        }
    }
}
