using System;
using System.Collections;
using Vectors.Vectors;
using System.Text;

namespace Vectors.Iterators
{
    public class CompressedVectorIterator : IEnumerator
    {
        private CompressedVector _vector;
        private int _index = -1;
        private int _counter = 0;

        public CompressedVectorIterator(CompressedVector vector)
        {
            _vector = vector;
        }

        public int Current => _vector.Vector[_index].Item1;
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _counter--;

            if (_counter< 0)
            {
                _index++;
                if (_index == _vector.Vector.Length)
                    return false;

                _counter = _vector.Vector[_index].Item2 - 1;
            }

            return true;
        }

        public void Reset()
        {
            _index = -1;
            _counter = 0;
        }
    }

    public class ReverseCompressedVectorIterator : IEnumerator
    {
        private CompressedVector _vector;
        private int _index;
        private int _counter = 0;

        public ReverseCompressedVectorIterator(CompressedVector vector)
        {
            _vector = vector;
            _index = vector.Vector.Length;
        }

        public int Current => _vector.Vector[_index].Item1;
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _counter--;

            if (_counter < 0)
            {
                _index--;
                if (_index == -1)
                    return false;

                _counter = _vector.Vector[_index].Item2 - 1;
            }

            return true;
        }

        public void Reset()
        {
            _index = _vector.Vector.Length;
            _counter = 0;
        }
    }
}
