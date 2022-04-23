using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class design_hit_counter
    {
        private Queue<int> _queue = new Queue<int>();
        private int _count = 0;

        public void Hit(int timestamp)
        {
            _queue.Enqueue(timestamp);
            _count++;
        }

        public int GetHits(int timestamp)
        {
            if (!_queue.Any())
            {
                return 0;
            }

            while (_queue.Peek() < timestamp - 299)
            {
                _queue.Dequeue();
                _count--;
                if (!_queue.Any())
                {
                    return 0;
                }
            }

            return _count;
        }
    }
}

