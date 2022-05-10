using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class design_most_recently_used_queue
    {
        public class MRUQueue
        {
            private List<int> _list;

            public MRUQueue(int n)
            {
                _list = new List<int>(n);
                for (int i = 1; i <= n; i++)
                {
                    _list.Add(n);
                }
            }

            public int Fetch(int k)
            {
                k--;
                var res = _list[k];
                _list.RemoveAt(k);
                _list.Add(res);
                return res;
            }
        }
    }
}
