using System;
namespace LeetCode
{
    public class widest_vertical_area_between_two_points_containing_no_points
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            var xPoints = new int[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                xPoints[i] = points[i][0];
            }

            Array.Sort(xPoints);
            var res = 0;
            for (int i = 1; i < xPoints.Length; i++)
            {
                var dif = xPoints[i] - xPoints[i - 1];
                res = Math.Max(res, dif);
            }

            return res;
        }
    }
}
