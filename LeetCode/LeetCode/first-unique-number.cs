using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class FirstUnique
    {
        private Dictionary<int, int> _count = new Dictionary<int, int>();
        private Queue<int> _queue = new Queue<int>();


        public FirstUnique(int[] nums)
        {
            foreach (var item in nums)
            {
                Add(item);
            }
        }

        public int ShowFirstUnique()
        {
            while (_queue.Any())
            {
                var current = _queue.Peek();
                if (_count[current] == 1)
                {
                    return current;
                }
                else
                {
                    _queue.Dequeue();
                }
            }

            return -1;
        }

        public void Add(int value)
        {
            if (_count.ContainsKey(value))
            {
                _count[value]++;
            }
            else
            {
                _count.Add(value, 1);
                _queue.Enqueue(value);
            }
        }
    }
}
