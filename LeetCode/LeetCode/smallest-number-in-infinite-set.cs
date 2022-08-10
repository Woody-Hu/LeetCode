using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class smallest_number_in_infinite_set
    {
        public class SmallestInfiniteSet
        {
            private SortedList<int, int> _list = new SortedList<int, int>();
            public SmallestInfiniteSet()
            {
                for (int i = 1; i <= 1000; i++)
                {
                    _list.Add(i, i);
                }
            }

            public int PopSmallest()
            {
                var res = _list.Keys.First();
                _list.Remove(res);
                return res;
            }

            public void AddBack(int num)
            {
                if (!_list.ContainsKey(num))
                {
                    _list.Add(num, num);
                }
            }
        }
    }
}
