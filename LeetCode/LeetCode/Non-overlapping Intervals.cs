using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Non_overlapping_Intervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return 0;
            }

            Array.Sort(intervals, (ints, ints1) => ints[1] - ints1[1]);
            var currentEnd = intervals[0][1];
            var noneOverlapCount = 1;
            for (int i = 0; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= currentEnd)
                {
                    noneOverlapCount++;
                    currentEnd = intervals[i][1];
                }
            }

            return intervals.Length - noneOverlapCount;

        }
    }
}
