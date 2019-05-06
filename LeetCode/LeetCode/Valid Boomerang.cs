using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Valid_Boomerang
    {
        public bool IsBoomerang(int[][] points)
        {
            var dx1 = points[1][0] - points[0][0];
            var dx2 = points[2][0] - points[0][0];
            var dy1 = points[1][1] - points[0][1];
            var dy2 = points[2][1] - points[0][1];

            return dy1 * dx2 != dy2 * dx1;
        }
    }
}
