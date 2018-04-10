using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LargestTriangleArea
    {
        public double LargestTriangleAreaMethod(int[][] points)
        {
            double returnValue = 0.0d;

            foreach (var i in points)
            {
                foreach (var j in points)
                {
                    foreach (var k in points)
                    {
                        returnValue = Math.Max(returnValue, 0.5 * Math.Abs(i[0] * j[1] + j[0] * k[1] + k[0] * i[1]- j[0] * i[1] - k[0] * j[1] - i[0] * k[1]));
                    }
                }
            }

            return returnValue;
        }
    }
}
