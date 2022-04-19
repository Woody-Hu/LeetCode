using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Insert_Interval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var ans = new List<int[]>();
            int[] toAdd = newInterval;

            for (int i = 0; i < intervals.Length; i++)
            {
                if (intervals[i][0] > toAdd[1])
                {
                    ans.Add(toAdd);
                    toAdd = intervals[i];
                }
                else if (intervals[i][1] >= toAdd[0])
                    toAdd = new int[] {Math.Min(intervals[i][0], toAdd[0]),
                                   Math.Max(intervals[i][1], toAdd[1]) };
                else ans.Add(intervals[i]);
            }

            ans.Add(toAdd);
            return ans.ToArray();
        }
    }
}
