using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class K_Closest_Points_to_Origin
    {
        public int[][] KClosest(int[][] points, int K)
        {
            Array.Sort(points, (ints, ints1) =>
            {
                var value1 = ints[0] * ints[0] + ints[1] * ints[1];
                var value2 = ints1[0] * ints1[0] + ints1[1] * ints1[1];
                return value1 - value2;
            });

            var returnValue = new int[K][];
            Array.Copy(points, returnValue, K);
            return returnValue;
        }
    }
}
