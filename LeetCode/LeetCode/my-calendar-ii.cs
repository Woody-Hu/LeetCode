using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class my_calendar_ii
    {
        public class MyCalendarTwo
        {
            private Dictionary<int, int[]> _treeSum = new Dictionary<int, int[]>();

            public MyCalendarTwo()
            {

            }

            public bool Book(int start, int end)
            {
                UpdateTree(start, end - 1, 1, 0, 1000000000, 1);
                if (!_treeSum.ContainsKey(1))
                {
                    _treeSum.Add(1, new int[2]);
                }

                if (_treeSum[1][0] > 2)
                {
                    UpdateTree(start, end - 1, -1, 0, 1000000000, 1);
                    return false;
                }

                return true;
            }

            private void UpdateTree(int start, int end, int val, int l, int r, int i)
            {
                if (r < start || end < l)
                {
                    return;
                }

                if (!_treeSum.ContainsKey(i))
                {
                    _treeSum.Add(i, new int[2]);
                }

                if (start <= l && r <= end)
                {
                    _treeSum[i][0] += val;
                    _treeSum[i][1] += val;
                }
                else
                {
                    var mid = (l + r) / 2;
                    UpdateTree(start, end, val, l, mid, 2 * i);
                    UpdateTree(start, end, val, mid + 1, r, 2 * i + 1);
                    if (!_treeSum.ContainsKey(2*i))
                    {
                        _treeSum.Add(2*i, new int[2]);
                    }

                    if (!_treeSum.ContainsKey(2 * i + 1))
                    {
                        _treeSum.Add(2 * i + 1, new int[2]);
                    }
                    _treeSum[i][0] = _treeSum[i][1] + Math.Max(_treeSum[2 * i][0], _treeSum[i * 2 + 1][0]);
                }
            }
        }
    }
}
