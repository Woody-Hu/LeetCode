using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class most_stones_removed_with_same_row_or_column
    {
        public int RemoveStones(int[][] stones)
        {
            var find = new UnionFind();
            foreach (var item in stones)
            {
                find.Union(item[0] + 10001, item[1]);
            }

            return stones.Length - find.Count;
        }

        private class UnionFind
        {
            private readonly Dictionary<int, int> _dict = new Dictionary<int, int>();

            internal int Count { get; set; }

            internal int Find(int input)
            {
                if (!_dict.ContainsKey(input))
                {
                    _dict.Add(input, input);
                    Count++;
                }

                if (input != _dict[input])
                {
                    _dict[input] = Find(_dict[input]);
                }

                return _dict[input];
            }

            internal void Union(int l, int r)
            {
                var rl = Find(l);
                var rr = Find(r);
                if (rl == rr)
                {
                    return;
                }

                _dict[rl] = rr;
                Count--;
                return;
            }
        }
    }
}

