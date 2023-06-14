using System;
namespace LeetCode
{
	public class remove_covered_intervals
	{
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a1, a2) => a1[0] == a2[0] ? a2[1] - a1[1] : a1[0] - a2[0]);
            var res = intervals.Length;
            var max = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][1] <= max)
                {
                    res--;
                }
                else
                {
                    max = intervals[i][1];
                }
            }

            return res;
        }
    }
}

