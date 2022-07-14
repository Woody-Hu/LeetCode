using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class interval_list_intersections
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            var list = new List<int[]>();
            var i = 0;
            var j = 0;
            while (i < firstList.Length && j < secondList.Length)
            {
                var firstItem = firstList[i];
                var secondItem = secondList[j];
                var low = Math.Max(firstItem[0], secondItem[0]);
                var large = Math.Min(firstItem[1], secondItem[1]);
                if (low <= large)
                {
                    list.Add(new int[] { low, large });
                }

                if (firstItem[1] < secondItem[1])
                    i++;
                else
                    j++;
            }

            return list.ToArray();
        }
    }
}
