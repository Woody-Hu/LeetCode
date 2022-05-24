using System;
namespace LeetCode
{
    public class design_circular_queue
    {
        public class MyCircularQueue
        {
            private int[] _queue;
            private int _count;
            private int _size;
            private int _head;

            public MyCircularQueue(int k)
            {
                _queue = new int[k];
                _count = 0;
                _size = k;
                _head = 0;
            }

            public bool EnQueue(int value)
            {
                if (_count == _size)
                {
                    return false;
                }

                var i = (_head + _count) % _size;
                _queue[i] = value;
                _count++;
                return true;
            }

            public bool DeQueue()
            {
                if (_count == 0)
                {
                    return false;
                }

                var i = (_head + 1) % _size;
                _head = i;
                _count--;
                return true;
            }

            public int Front()
            {
                if (_count == 0)
                {
                    return -1;
                }

                var i = _head % _size;
                return _queue[i];
            }

            public int Rear()
            {
                if (_count == 0)
                {
                    return -1;
                }

                var i = (_head + _count - 1) % _size;
                return _queue[i];
            }

            public bool IsEmpty()
            {
                return _count == 0;
            }

            public bool IsFull()
            {
                return _count == _size;
            }
        }
    }
}
