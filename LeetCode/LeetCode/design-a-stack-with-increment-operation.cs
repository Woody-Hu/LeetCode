using System;
namespace LeetCode
{
    public class design_a_stack_with_increment_operation
    {
        public class CustomStack
        {
            private int[] _data;
            private int[] _add;
            private int _top;

            public CustomStack(int maxSize)
            {
                _top = -1;
                _data = new int[maxSize];
                _add = new int[maxSize];
            }

            public void Push(int x)
            {
                if (_top < _data.Length - 1 )
                {
                    _top++;
                    _data[_top] = x;
                }
            }

            public int Pop()
            {
                if (_top == -1)
                {
                    return -1;
                }

                var res = _data[_top] + _add[_top];
                if (_top > 0)
                {
                    _add[_top - 1] += _add[_top];
                }

                _add[_top] = 0;
                _top--;
                return res;
            }

            public void Increment(int k, int val)
            {
                var limit = Math.Min(k - 1, _top);
                if (limit >= 0)
                {
                    _add[limit] += val;
                }
            }
        }
    }
}
