using System.Collections;
using Vectors.Vectors;

namespace Vectors.Iterators
{
    public class ArrayVectorIterator : IEnumerator
    {
        private ArrayVector _vector;
        private int _index = -1;

        public ArrayVectorIterator(ArrayVector vector)
        {
            _vector = vector;
        }

        public object Current =>_vector.Vector[_index];

        public bool MoveNext()
        {
            _index++;
            return (_index < _vector.Vector.Length);
        }

        public void Reset()
        {
            _index = -1;
        }
    }

    public class ReverseArrayVectorIterator : IEnumerator
    {
        private ArrayVector _vector;
        private int _index;
        
        public ReverseArrayVectorIterator(ArrayVector vector)
        {
            _vector = vector;
            _index = _vector.Vector.Length;
        }

        public object Current => _vector.Vector[_index];

        public bool MoveNext()
        {
            _index--;
            return (_index >= 0);
        }

        public void Reset()
        {
            _index = _vector.Vector.Length;
        }
    }
}
