using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class zigzag_iterator
    {
        public class ZigzagIterator
        {
            private List<int> _list;
            private int _p = 0;

            public ZigzagIterator(IList<int> v1, IList<int> v2)
            {
                _list = new List<int>(v1.Count + v2.Count);
                var minLength = Math.Min(v1.Count, v2.Count);
                var i = 0;
                for (; i < minLength; i++)
                {
                    _list.Add(v1[i]);
                    _list.Add(v2[i]);
                }

                if (i < v1.Count)
                {
                    for (; i < v1.Count; i++)
                    {
                        _list.Add(v1[i]);
                    }
                }
                else if (i < v2.Count)
                {
                    for (; i < v2.Count; i++)
                    {
                        _list.Add(v2[i]);
                    }
                }
            }

            public bool HasNext()
            {
                return _p < _list.Count;
            }

            public int Next()
            {
                return _list[_p++];
            }
        }

    }
}
