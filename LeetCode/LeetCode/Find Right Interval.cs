using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace LeetCode
{
    class Find_Right_Interval
    {
        public int[] FindRightInterval(int[][] intervals)
        {
            var list = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < intervals.Length; i++)
            {
                list.Add(new KeyValuePair<int, int>(intervals[i][0], i));
            }

            list.Sort(new DefaultCompare());

            var res = new List<int>();
            for (int i = 0; i < intervals.Length; i++)
            {
                var index = BinarySearchCeiling(list, intervals[i][1]);
                res.Add(index == -1 ? index : list[index].Value);
            }

            return res.ToArray();
        }

        private int BinarySearchCeiling(List<KeyValuePair<int, int>> list, int value)
        {
            int cur, m, l;
            m = 0;
            l = list.Count - 1;
            if (value < list[m].Key || list[l].Key < value)
                return -1;
            while (l - m > 1)
            {
                cur = Convert.ToInt16(Math.Ceiling((m + l) / 2.0));
                if (list[cur].Key < value)
                    m = cur;
                else if (list[cur].Key > value)
                    l = cur;
                else
                    return cur;
            }

            return l;
        }

        private class DefaultCompare : IComparer<KeyValuePair<int, int>>
        {
            public int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return x.Key - y.Key;
            }
        }
    }
}
