using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class RandomizedSet
    {
        private HashSet<int> _set = new HashSet<int>();
        private List<int> _list = new List<int>();
        private Random _random = new Random();

        /** Initialize your data structure here. */
        public RandomizedSet()
        {

        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (!_set.Contains(val))
            {
                _set.Add(val);
                if (_list == null)
                {
                    _list = _set.ToList();
                }
                _list.Add(val);
                return true;
            }

            return false;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (_set.Contains(val))
            {
                _set.Remove(val);
                _list = null;
                return true;
            }

            return false;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            if (_list == null)
            {
                _list = _set.ToList();
            }

            return _list[_random.Next(_list.Count)];
        }
   }
}
