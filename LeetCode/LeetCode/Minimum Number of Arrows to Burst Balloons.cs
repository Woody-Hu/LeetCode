using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Number_of_Arrows_to_Burst_Balloons
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points.Length < 2)
            {
                return points.Length;
            }

            Array.Sort(points, (ints, ints1) => ints[1] - ints1[1] );

            var res = 1;
            var currentIndex = 0;
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i][0] > points[currentIndex][1])
                {
                    currentIndex = i;
                    res++;
                }
            }

            return res;
        }
    }
}
