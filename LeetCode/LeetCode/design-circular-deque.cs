using System;
namespace LeetCode
{
	public class design_circular_deque
	{
        public class MyCircularDeque
        {
            private readonly int[] _data;

            private int _rear;

            private int _front;

            private int _capacity;

            public MyCircularDeque(int k)
            {
                _capacity = k + 1;
                _rear = _front = 0;
                _data = new int[k + 1];
            }

            public bool InsertFront(int value)
            {
                if (IsFull())
                {
                    return false;
                }

                _front = (_front - 1 + _capacity) % _capacity;
                _data[_front] = value;
                return true;
            }

            public bool InsertLast(int value)
            {
                if (IsFull())
                {
                    return false;
                }

                _data[_rear] = value;
                _rear = (_rear + 1) % _capacity;
                return true;
            }

            public bool DeleteFront()
            {
                if (IsEmpty())
                {
                    return false;
                }

                _front = (_front + 1) % _capacity;
                return true;
            }

            public bool DeleteLast()
            {
                if (IsEmpty())
                {
                    return false;
                }

                _rear = (_rear -1 + _capacity) % _capacity;
                return true;
            }

            public int GetFront()
            {
                if (IsEmpty())
                {
                    return -1;
                }

                return _data[_front];
            }

            public int GetRear()
            {
                if (IsEmpty())
                {
                    return -1;
                }

                return _data[(_rear - 1 + _capacity) % _capacity];
            }

            public bool IsEmpty()
            {
                return _rear == _front;
            }

            public bool IsFull()
            {
                return (_rear + 1) % _capacity == _front;
            }
        }
    }
}

