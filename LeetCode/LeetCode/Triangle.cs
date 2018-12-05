using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var length = triangle.Count;

            for (var i = length - 2; i >=0; i--)
            {
                for (var j = 0; j <= i; j++)
                {
                    var perValue = Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                    var cureValue = perValue + triangle[i][j];
                    triangle[i][j] = cureValue;
                }
            }

            return triangle[0][0];

        }
    }
}
