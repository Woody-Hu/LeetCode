using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class qIsx9U
	{
		public qIsx9U()
		{
		}

        public class MovingAverage
        {
            private readonly Queue<int> _queue;

            private readonly int _size;

            private double _sum;

            /** Initialize your data structure here. */
            public MovingAverage(int size)
            {
                _queue = new Queue<int>();
                this._size = size;
                _sum = 0.0d;
            }

            public double Next(int val)
            {
                if (_queue.Count == _size)
                {
                    _sum -= _queue.Dequeue();
                }

                _queue.Enqueue(val);
                _sum += val;
                return _sum / _queue.Count;
            }
        }
    }
}

