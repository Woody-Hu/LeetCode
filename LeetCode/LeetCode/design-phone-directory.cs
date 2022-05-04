using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class design_phone_directory
    {
        public design_phone_directory()
        {
        }

        public class PhoneDirectory
        {
            private HashSet<int> _set = new HashSet<int>();
            private Queue<int>  _queue = new Queue<int>();

            public PhoneDirectory(int maxNumbers)
            {
                for (int i = 0; i < maxNumbers; i++)
                {
                    _queue.Enqueue(i);
                }
            }

            public int Get()
            {
                if (_queue.Any())
                {
                    var value = _queue.Dequeue();
                    _set.Add(value);
                    return value;
                }

                return -1;
            }

            public bool Check(int number)
            {
                return !_set.Contains(number);
            }

            public void Release(int number)
            {
                if (!_set.Contains(number))
                {
                    return;
                }

                _set.Remove(number);
                _queue.Enqueue(number);
            }
        }
    }
}
