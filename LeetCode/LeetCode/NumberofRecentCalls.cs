using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NumberofRecentCalls
    {
        private Queue<int> _queue = new Queue<int>();

        public NumberofRecentCalls()
        {

        }

        public int Ping(int t)
        {
            while (_queue.Count != 0 && _queue.Peek() < t-3000)
            {
                _queue.Dequeue();
            }

            _queue.Enqueue(t);

            return _queue.Count;
        }
    }
}
