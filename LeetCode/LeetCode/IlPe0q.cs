using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class IlPe0q
	{
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var n = triangle.Count;
            var f = new int[n, n];
            f[0, 0] = triangle[0][0];
            for (int i = 1; i < n; i++)
            {
                f[i, 0] = f[i - 1, 0] + triangle[i][0];
                for (int j = 1; j < i; j++)
                {
                    f[i, j] = Math.Min(f[i - 1, j - 1], f[i - 1, j]) + triangle[i][j];
                }

                f[i, i] = f[i - 1, i - 1] + triangle[i][i];
            }

            var minTotal = f[n - 1, 0];
            for (int i = 1; i < n; i++)
            {
                minTotal = Math.Min(minTotal, f[n - 1, i]);
            }

            return minTotal;
        }
    }
}

