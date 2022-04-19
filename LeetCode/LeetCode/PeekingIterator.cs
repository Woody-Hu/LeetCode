using System;
using System.Collections.Generic;

namespace LeetCode
{
    class PeekingIterator
    {
        private IEnumerator<int> _iterator;
        private bool _next;
        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            // initialize any member here.
            _iterator = iterator;
            _next = true;
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return _iterator.Current;
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            var res = _iterator.Current;
            _next = _iterator.MoveNext();
            return res;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return _next;
        }
    }
}
