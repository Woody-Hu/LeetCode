using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class moving_average_from_data_stream
    {
        public class MovingAverage
        {
            private Queue<int> _queue = new Queue<int>();
            private int _size = 0;

            public MovingAverage(int size)
            {
                _size = size;
            }

            public double Next(int val)
            {
                if (_queue.Count >= _size)
                {
                    _queue.Dequeue();
                }

                _queue.Enqueue(val);
                return _queue.Average();
            }
        }
    }
}
