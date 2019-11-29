using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Time_Visiting_All_Points
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var res = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                var x = Math.Abs(points[i + 1][0] - points[i][0]);
                var y = Math.Abs(points[i + 1][1] - points[i][1]);
                res += Math.Max(x, y);
            }

            return res;
        }
    }
}
